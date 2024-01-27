#pragma once
#include "stdafx.h"
#include "Snapshotable.h"
#include "APU.h"
#include "BaseExpansionAudio.h"
#include "Console.h"
#include "emu2149.h"

//#define SSG_USE_OLD_EMU
#ifndef SSG_USE_OLD_EMU
#define SSG_USE_EMU2149
#endif

#ifdef SSG_USE_EMU2149
template<AudioChannel...channels>
class SSGAudio : public BaseExpansionAudio
{
private:
	std::unique_ptr<PSG, void(*)(PSG*)> _psg;
	uint8_t _currentRegister;
	int16_t _lastOutput;
	int16_t _currentOutput;
	double _clock;
	bool _processTick;
	static constexpr uint8_t cycleCount = 1;

	void UpdateOutputLevel()
	{
		(_console->GetApu()->AddExpansionAudioDelta(channels, _currentOutput - _lastOutput), ...);
		_lastOutput = _currentOutput;
	}

protected:
	void StreamState(bool saving) override
	{
		BaseExpansionAudio::StreamState(saving);
		ValueInfo<PSG> psg{ _psg.get() };
		Stream( _currentRegister, _lastOutput, _clock, psg);
		if (!saving) PSG_setVolumeMode(_psg.get(), _psg->volumeMode);
	}

	void ClockAudio() override
	{
		_clock += GetSSGClockFrequency() / (double)_console->GetCpu()->GetClockRate(_console->GetModel());

		while (_clock >= cycleCount)
		{
				_currentOutput = 0;

			for (uint8_t cycle = 0; cycle < cycleCount; cycle++)
			{
				_clock--;
				_currentOutput = PSG_calc(_psg.get());
			}

				_currentOutput /= 26;

			UpdateOutputLevel();
		}
	}

	virtual uint32_t GetSSGClockFrequency()
	{
		return _console->GetCpu()->GetClockRate(_console->GetModel()) / 2;
	}

public:
	SSGAudio(shared_ptr<Console> console) : BaseExpansionAudio(console), _psg{ PSG_new(1 , 1), &PSG_delete }
	{
		_currentRegister = 0;
		_lastOutput = 0;
		_clock = 0;
		PSG_reset(_psg.get());
	}

	void WriteRegister(uint16_t addr, uint8_t value)
	{
		switch (addr) {
		case 0xC000:
			_currentRegister = value;
			break;

		case 0xE000:
			if (_currentRegister <= 0xF)
				PSG_writeReg(_psg.get(), _currentRegister, value);
			break;
		}
	}
};
#else
template<AudioChannel...channels>
class SSGAudio : public BaseExpansionAudio
{
private:
	uint8_t _volumeLut[0x10];
	uint8_t _currentRegister;
	uint8_t _registers[0x10];
	int16_t _lastOutput;
	int16_t _timer[3];
	uint8_t _toneStep[3];
	double _clock;
	bool _processTick;

	uint16_t GetPeriod(int channel)
	{
		return _registers[channel * 2] | (_registers[channel * 2 + 1] << 8);
	}

	uint16_t GetEnvelopePeriod()
	{
		return _registers[0x0B] | (_registers[0x0C] << 8);
	}

	uint8_t GetNoisePeriod()
	{
		return _registers[6];
	}

	uint8_t GetVolume(int channel)
	{
		return _volumeLut[_registers[8 + channel] & 0x0F];
	}
	
	bool IsEnvelopeEnabled(int channel)
	{
		return (_registers[8 + channel] & 0x10) == 0x10;
	}

	bool IsToneEnabled(int channel)
	{
		return ((_registers[7] >> channel) & 0x01) == 0x00;
	}

	bool IsNoiseEnabled(int channel)
	{
		return ((_registers[7] >> (channel + 3)) & 0x01) == 0x00;
	}
	
	void UpdateChannel(int channel)
	{
		_timer[channel]--;
		if(_timer[channel] <= 0) {
			_timer[channel] = GetPeriod(channel);
			_toneStep[channel] = (_toneStep[channel] + 1) & 0x0F;
		}
	}

	void UpdateOutputLevel()
	{
		int16_t summedOutput = 0;
		for(int i = 0; i < 3; i++) {
			if(IsToneEnabled(i) && _toneStep[i] < 0x08) {
				summedOutput += GetVolume(i);
			}
		}

		const auto delta = (summedOutput - _lastOutput);
		(_console->GetApu()->AddExpansionAudioDelta(channels, summedOutput - _lastOutput), ...);
		_lastOutput = summedOutput;
	}

protected:
	void StreamState(bool saving) override
	{
		BaseExpansionAudio::StreamState(saving);

		ArrayInfo<int16_t> timer{ _timer, 3 };
		ArrayInfo<uint8_t> registers{ _registers, 0x10 };
		ArrayInfo<uint8_t> toneStep{ _toneStep, 3 };
		Stream(timer, registers, toneStep, _currentRegister, _lastOutput, _clock);
	}

	void ClockAudio() override
	{
		_clock += GetSSGClockFrequency() / (double)_console->GetCpu()->GetClockRate(_console->GetModel());

		while (_clock >= 1)
		{
			for (int i = 0; i < 3; i++) {
				UpdateChannel(i);
			}

			_clock--;
			UpdateOutputLevel();
		}
	}

	virtual uint32_t GetSSGClockFrequency()
	{
		return _console->GetCpu()->GetClockRate(_console->GetModel()) / 2;
	}

public:
	SSGAudio(shared_ptr<Console> console) : BaseExpansionAudio(console)
	{
		memset(_timer, 0, sizeof(_timer));
		memset(_registers, 0, sizeof(_registers));
		memset(_toneStep, 0, sizeof(_toneStep));
		_currentRegister = 0;
		_lastOutput = 0;
		_clock = 0;

		double output = 1.0;
		_volumeLut[0] = 0;
		for(int i = 1; i < 0x10; i++) {
			//+1.5 dB 2x for every 1 step in volume
			output *= 1.1885022274370184377301224648922;
			output *= 1.1885022274370184377301224648922;

			_volumeLut[i] = (uint8_t)output;
		}
	}

	void WriteRegister(uint16_t addr, uint8_t value)
	{
		switch(addr) {
			case 0xC000:
				_currentRegister = value;
				break;
				 
			case 0xE000:
				if(_currentRegister <= 0xF)
					_registers[_currentRegister] = value;
				break;
		}
	}
};
#endif