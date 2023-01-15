// NTSC filter based on EMMIR's composite modem
// https://github.com/LMP88959/NTSC-CRT
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
	uint16_t* _ppuOutputBuffer;
	bool _ntscBorder = true;

	void GenerateArgbFrame(uint32_t* frameBuffer);

protected:
	void OnBeforeApplyFilter();

public:
	LMP88959NtscFilter(shared_ptr<Console> console);
	virtual ~LMP88959NtscFilter();

	virtual void ApplyFilter(uint16_t *ppuOutputBuffer);
	virtual FrameInfo GetFrameInfo();
};