#pragma once
#include "stdafx.h"
#include "BaseVideoFilter.h"
#include "../Utilities/crt.h"

class Console;

class LMP88959NtscFilter : public BaseVideoFilter
{
private:
	struct NES_NTSC_SETTINGS _nesNTSC;
	struct CRT _crt;
	bool _keepVerticalRes = false;
	uint32_t* _frameBuffer;
	bool _ntscBorder = true;
	int _resDivider = 1;

	void RecursiveBlend(int iterationCount, uint64_t* output, uint64_t* currentLine, uint64_t* nextLine, int pixelsPerCycle, bool verticalBlend);

protected:
	void OnBeforeApplyFilter();

public:
	LMP88959NtscFilter(shared_ptr<Console> console, int resDivider);
	virtual ~LMP88959NtscFilter();

	virtual void ApplyFilter(uint16_t *ppuOutputBuffer);
	virtual FrameInfo GetFrameInfo();
};