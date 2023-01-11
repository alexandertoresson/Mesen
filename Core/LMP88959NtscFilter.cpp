// NTSC filter based on EMMIR's composite modem
// https://github.com/LMP88959/NTSC-CRT
#include "stdafx.h"
#include "LMP88959NtscFilter.h"
#include "PPU.h"
#include "EmulationSettings.h"
#include "Console.h"

LMP88959NtscFilter::LMP88959NtscFilter(shared_ptr<Console> console, int resDivider) : BaseVideoFilter(console)
{
	_resDivider = resDivider;
	_frameBuffer = new uint32_t[(256) * 240]();
}

FrameInfo LMP88959NtscFilter::GetFrameInfo()
{
	OverscanDimensions overscan = GetOverscan();
	if (_keepVerticalRes) {
		return { overscan.GetScreenWidth() * 8 / _resDivider, overscan.GetScreenHeight(), PPU::ScreenWidth, PPU::ScreenHeight, 4 };
	}
	else {
		return { overscan.GetScreenWidth() * 8 / _resDivider, overscan.GetScreenHeight() * 8 / _resDivider, PPU::ScreenWidth, PPU::ScreenHeight, 4 };
	}
}

void LMP88959NtscFilter::OnBeforeApplyFilter()
{
	_ntscBorder = (_console->GetModel() == NesModel::NTSC);

	PictureSettings pictureSettings = _console->GetSettings()->GetPictureSettings();
	NtscFilterSettings ntscSettings = _console->GetSettings()->GetNtscFilterSettings();

	_keepVerticalRes = ntscSettings.KeepVerticalResolution;

	crt_init(&_crt, GetOverscan().GetScreenWidth() * 8 / _resDivider, GetOverscan().GetScreenHeight() * 8 / _resDivider, (int*)(_frameBuffer));

	_crt.hue = static_cast<int>(pictureSettings.Hue * 180.0);
	_crt.saturation = static_cast<int>(((pictureSettings.Saturation + 1.0) / 2.0) * 50.0);
	_crt.brightness = static_cast<int>(pictureSettings.Brightness * 100.0);
	_crt.contrast = static_cast<int>(((pictureSettings.Contrast + 1.0) / 2.0) * 360.0);
	_crt.noise = static_cast<int>(ntscSettings.Noise * 500.0);

	_nesNTSC.data = nullptr;
	_nesNTSC.w = static_cast<int>(PPU::ScreenWidth);
	_nesNTSC.h = static_cast<int>(PPU::ScreenHeight);
	_nesNTSC.raw = 1;
	_nesNTSC.as_color = 1;
	_nesNTSC.dot_crawl_offset = 0;
	_nesNTSC.starting_phase = 0;
	_nesNTSC.cc[0] = -1;
	_nesNTSC.cc[1] = 0;
	_nesNTSC.cc[2] = 1;
	_nesNTSC.cc[3] = 0;
	_nesNTSC.ccs = 1;

}

void LMP88959NtscFilter::ApplyFilter(uint16_t *ppuOutputBuffer)
{
	uint8_t phase = _console->GetModel() == NesModel::NTSC ? _console->GetStartingPhase() : 0;
	//for (int i = 0; i < 240; i++) {
	//	nes_ntsc_blit(&_ntscData,
	//		// input += in_row_width;
	//		ppuOutputBuffer + PPU::ScreenWidth * i,
	//		_ntscBorder ? _console->GetPpu()->GetCurrentBgColor() : 0x0F,
	//		PPU::ScreenWidth,
	//		phase,
	//		PPU::ScreenWidth,
	//		1,
	//		// rgb_out = (char*) rgb_out + out_pitch;
	//		reinterpret_cast<char*>(_frameBuffer) + (NES_NTSC_OUT_WIDTH(PPU::ScreenWidth) * 4 * i),
	//		NES_NTSC_OUT_WIDTH(PPU::ScreenWidth) * 4);

	//	phase = (phase + 1) % 3;
	//}
	_nesNTSC.data = (unsigned short*)(ppuOutputBuffer);
	_nesNTSC.dot_crawl_offset = phase;
	_nesNTSC.starting_phase = phase;

	crt_nes2ntsc(&_crt, &_nesNTSC);
	crt_draw(&_crt);

	GenerateArgbFrame(_frameBuffer);
}

void LMP88959NtscFilter::GenerateArgbFrame(uint32_t *frameBuffer)
{
	uint32_t* outputBuffer = GetOutputBuffer();
	OverscanDimensions overscan = GetOverscan();
	int overscanLeft = overscan.Left > 0 ? (overscan.Left) : 0;
	int overscanRight = overscan.Right > 0 ? (overscan.Right) : 0;
	int rowWidth = (PPU::ScreenWidth);
	int rowWidthOverscan = rowWidth - overscanLeft - overscanRight;

	if(_keepVerticalRes) {
		frameBuffer += rowWidth * overscan.Top + overscanLeft;
		for(uint32_t i = 0, len = overscan.GetScreenHeight(); i < len; i++) {
			memcpy(outputBuffer, frameBuffer, rowWidthOverscan * sizeof(uint32_t));
			outputBuffer += rowWidthOverscan;
			frameBuffer += rowWidth;
		}
	} else {
		double scanlineIntensity = 1.0 - _console->GetSettings()->GetPictureSettings().ScanlineIntensity;
		bool verticalBlend = _console->GetSettings()->GetNtscFilterSettings().VerticalBlend;

		for(int y = PPU::ScreenHeight - 1 - overscan.Bottom; y >= (int)overscan.Top; y--) {
			uint32_t const* in = frameBuffer + y * rowWidth;
			uint32_t* out = outputBuffer + (y - overscan.Top) * 2 * rowWidthOverscan;

			if(verticalBlend || scanlineIntensity < 1.0) {
				for(int x = 0; x < rowWidthOverscan; x++) {
					uint32_t prev = in[overscanLeft];
					uint32_t next = y < 239 ? in[overscanLeft + rowWidth] : 0;

					*out = 0xFF000000 | prev;

					/* mix 24-bit rgb without losing low bits */
					uint32_t mixed;
					if(verticalBlend) {
						mixed = (prev + next + ((prev ^ next) & 0x030303)) >> 1;
					} else {
						mixed = prev;
					}

					if(scanlineIntensity < 1.0) {
						uint8_t r = (mixed >> 16) & 0xFF, g = (mixed >> 8) & 0xFF, b = mixed & 0xFF;
						r = (uint8_t)(r * scanlineIntensity);
						g = (uint8_t)(g * scanlineIntensity);
						b = (uint8_t)(b * scanlineIntensity);
						*(out + rowWidthOverscan) = 0xFF000000 | (r << 16) | (g << 8) | b;
					} else {
						*(out + rowWidthOverscan) = 0xFF000000 | mixed;
					}
					in++;
					out++;
				}
			} else {
				for(int i = 0; i < rowWidthOverscan; i++) {
					out[i] = 0xFF000000 | in[overscanLeft+i];
				}
				memcpy(out + rowWidthOverscan, out, rowWidthOverscan * sizeof(uint32_t));
			}
		}
	}
}

LMP88959NtscFilter::~LMP88959NtscFilter()
{
	delete[] _frameBuffer;
}