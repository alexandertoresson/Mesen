#pragma once
#include "stdafx.h"
#include "BaseVideoFilter.h"
#include "../Utilities/crt.h"

class Console;

class LMP88959NtscFilter : public BaseVideoFilter
{
private:
	struct NTSC_SETTINGS _ntsc;
	struct CRT _crt;
	bool _keepVerticalRes = false;
	bool _useExternalPalette = true;
	uint8_t _palette[512 * 3];
	uint32_t* _ntscBuffer;
	bool _ntscBorder = true;

	void GenerateArgbFrame(uint32_t *outputBuffer);

protected:
	void OnBeforeApplyFilter();

public:
	LMP88959NtscFilter(shared_ptr<Console> console);
	virtual ~LMP88959NtscFilter();

	virtual void ApplyFilter(uint16_t *ppuOutputBuffer);
	virtual FrameInfo GetFrameInfo();
};