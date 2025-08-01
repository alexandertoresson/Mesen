// NTSC filter based on EMMIR's composite modem
// https://github.com/LMP88959/NTSC-PAL_CRT
#pragma once
#include "stdafx.h"
#include "BaseVideoFilter.h"
#include "../Utilities/pal_core.h"
#include "../Utilities/pal_nes.h"

class Console;

class LMP88959PalFilter : public BaseVideoFilter
{
private:
	struct PAL_SETTINGS _nesPAL;
	struct PAL_CRT _crt;

	int _noise = 0;

	bool _keepVerticalRes = false;

	uint32_t* _frameBuffer;
	uint16_t* _ppuOutputBuffer;
	bool _ntscBorder = true;

	void GenerateArgbFrame(uint32_t* frameBuffer);

protected:
	void OnBeforeApplyFilter();

public:
	LMP88959PalFilter(shared_ptr<Console> console);
	virtual ~LMP88959PalFilter();

	virtual void ApplyFilter(uint16_t *ppuOutputBuffer);
	virtual FrameInfo GetFrameInfo();
};
