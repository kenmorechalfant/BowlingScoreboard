using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BowlingScoreboard.Models
{
    class ThrowAttempt
    {
        private string _result;
        private readonly int _totalPinCount = 10;
        private int _hitPinCount = 0;
        private int _startingPinCount;

        public ThrowAttempt()
        {
            Reset();
        }

        public void EnterResult(int remainingPins, string value)
        {
            if (remainingPins <= 0 || remainingPins > _totalPinCount) throw new Exception($"A valid ThrowAttempt must have between 0 and {_totalPinCount} remaining pins.");

            _startingPinCount = remainingPins;

            if (_startingPinCount == _totalPinCount)
            {
                Regex DigitOrStrike = new Regex(@"^[0-9xX]$");
                if (!DigitOrStrike.IsMatch(value)) throw new Exception("Invalid throw result. Please enter a digit 0-9 or an 'x' or 'X' for a Strike.");
            }

            if (_startingPinCount < _totalPinCount)
            {
                Regex DigitOrSpare = new Regex(@"^[0-9/]$");
                if (!DigitOrSpare.IsMatch(value)) throw new Exception("Invalid throw result. Please enter a digit 0-9 or '/' for a Spare.");
            }

            Regex SpareOrStrike = new Regex(@"^[xX/]$");

            if (SpareOrStrike.IsMatch(value))
            {
                _hitPinCount = _startingPinCount;
            }
            else
            {
                _hitPinCount = Convert.ToInt32(value);
            }

            _result = value;
        }

        internal void Reset()
        {
            _startingPinCount = 0;
            _hitPinCount = 0;
            _result = string.Empty;
    }

        public string Result
        {
            get { return _result; }
        }

        public int HitCount { get { return _hitPinCount; } }
    }
}
