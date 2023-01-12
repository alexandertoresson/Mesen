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
	_frameBuffer = new uint32_t[(256 * 8 / _resDivider) * (240 * 8 / _resDivider)]();
	memset(_crt.analog, 0, sizeof(_crt.analog));
	memset(_crt.inp, 0, sizeof(_crt.inp));
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

	crt_init(&_crt, (256 * 8 / _resDivider), _keepVerticalRes ? 240 : (240 * 8 / _resDivider), reinterpret_cast<int*>(GetOutputBuffer()));

	_crt.hue = static_cast<int>(pictureSettings.Hue * 180.0);
	_crt.saturation = static_cast<int>(((pictureSettings.Saturation + 1.0) / 2.0) * 25.0);
	_crt.brightness = static_cast<int>(pictureSettings.Brightness * 100.0);
	_crt.contrast = static_cast<int>(((pictureSettings.Contrast + 1.0) / 2.0) * 360.0);
	_crt.noise = static_cast<int>(ntscSettings.Noise * 500.0);

	_nesNTSC.w = static_cast<int>(PPU::ScreenWidth);
	_nesNTSC.h = static_cast<int>(PPU::ScreenHeight);
	_nesNTSC.raw = 0;
	_nesNTSC.as_color = 1;
	_nesNTSC.dot_crawl_offset = 0;
	_nesNTSC.cc[0] = 0;
	_nesNTSC.cc[1] = 1;
	_nesNTSC.cc[2] = 0;
	_nesNTSC.cc[3] = -1;
	_nesNTSC.ccs = 1;

}

void LMP88959NtscFilter::ApplyFilter(uint16_t *ppuOutputBuffer)
{
	uint8_t phase = _console->GetModel() == NesModel::NTSC ? _console->GetStartingPhase() : 0;

	_nesNTSC.data = reinterpret_cast<unsigned short*>(ppuOutputBuffer);
	_nesNTSC.dot_crawl_offset = phase;
	crt_nes2ntsc(&_crt, &_nesNTSC);
	crt_draw(&_crt);
}

LMP88959NtscFilter::~LMP88959NtscFilter()
{
	delete[] _frameBuffer;
}