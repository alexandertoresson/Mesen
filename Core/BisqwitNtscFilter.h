//NTSC filter based on Bisqwit's code/algorithm
//As described here:
//http://forums.nesdev.com/viewtopic.php?p=172329
#pragma once
#include "stdafx.h"
#include "BaseVideoFilter.h"
#include "../Utilities/AutoResetEvent.h"

class BisqwitNtscFilter : public BaseVideoFilter
{
private:
	const uint16_t _bitmaskLut[12] = { 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x80, 0x100, 0x200, 0x400, 0x800 };
	static constexpr int _paddingSize = 6;
	static constexpr int _signalsPerPixel = 8;
	static constexpr int _signalWidth = 258;

	std::thread _extraThread;
	AutoResetEvent _waitWork;
	atomic<bool> _stopThread;
	atomic<bool> _workDone;

	bool _keepVerticalRes = false;

	int _resDivider = 1;
	uint16_t *_ppuOutputBuffer = nullptr;
	
	/* Ywidth, Iwidth and Qwidth are the filter widths for Y,I,Q respectively.
	* All widths at 12 produce the best signal quality.
	* 12,24,24 would be the closest values matching the NTSC spec.
	* But off-spec values 12,22,26 are used here, to bring forth mild
	* "chroma dots", an artifacting common with badly tuned TVs.
	* Larger values = more horizontal blurring.
	*/
	int _yWidth, _iWidth, _qWidth;
	int _y;
	int _ir, _ig, _ib;
	int _qr, _qg, _qb;

	//To finetune hue, you would have to recalculate sinetable[]. (Coarse changes can be made with Phase0.)
	int8_t _sinetable[27]; // 8*sin(x*2pi/12)

	uint8_t _startingPhase = 0;

	//Precalculate the low and high signal chosen for each 64 base colors
	//with their respective attenuated values
	const int8_t _signalLow[2][0x40] = {
		// normal
		{
			// 0x
			32, -29, -29, -29, -29, -29, -29, -29, -29, -29, -29, -29, -29, -29, -15, -15,
			// 1x
			66, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15, -15,
			// 2x
			110, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, -15, -15,
			// 3x
			110, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, 71, -15, -15
		},
		// attenuated
		{
			// 0x
			26, -38, -38, -38, -38, -38, -38, -38, -38, -38, -38, -38, -38, -38, -15, -15,
			// 1x
			51, -28, -28, -28, -28, -28, -28, -28, -28, -28, -28, -28, -28, -28, -15, -15,
			// 2x
			82, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -15, -15,
			// 3x
			82, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, -15, -15
		}
	};

	const int8_t _signalHigh[2][0x40] = {
		// normal
		{
			// 0x
			32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, -29, -15, -15,
			// 1x
			66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, -15, -15, -15,
			// 2x
			105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 22, -15, -15,
			// 3x
			105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 105, 71, -15, -15,
			},
		// attenuated
		{
			// 0x
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, -38, -15, -15,
			// 1x
			31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, -28, -15, -15,
			// 2x
			58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, -1, -15, -15,
			// 3x
			58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 34, -15, -15,
		} 
	};

	void RecursiveBlend(int iterationCount, uint64_t *output, uint64_t *currentLine, uint64_t *nextLine, int pixelsPerCycle, bool verticalBlend);
	
	void NtscDecodeLine(int width, const int8_t* signal, uint32_t* target, int phase0);
	
	void GenerateNtscSignal(int8_t *ntscSignal, int &phase, int rowNumber);
	void DecodeFrame(int startRow, int endRow, uint32_t* outputBuffer, int startPhase);
	void OnBeforeApplyFilter();

public:
	BisqwitNtscFilter(shared_ptr<Console> console, int resDivider);
	virtual ~BisqwitNtscFilter();

	virtual void ApplyFilter(uint16_t *ppuOutputBuffer);
	virtual FrameInfo GetFrameInfo();
};