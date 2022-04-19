using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreboard.Models
{
    public class AddToResolvedFrameException : Exception
    {
        public AddToResolvedFrameException() { }

        public AddToResolvedFrameException(string message)
            : base(message)
        {
        }

        public AddToResolvedFrameException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    internal class Frame
    {
        protected int maxThrowCount = 2;
        private int currentThrow = 1;
        protected int pinCount = 10;
        private int pinsRemaining;
        private bool bResolved;

        public List<int> Throws { get; private set; }

        public Frame()
        {
            pinsRemaining = pinCount;
        }

        public string Score {
            get { return Convert.ToString(pinCount - pinsRemaining); }
        }

        // returns true if the Frame is over
        public bool AddResult(int result)
        {
            if (bResolved) throw new AddToResolvedFrameException("Cannot add a result to a completed frame.");

            Throws.Add(result);
            pinsRemaining -= result;

            currentThrow++;

            if (currentThrow == maxThrowCount)
            {
                bResolved = true;
                return true;
            }

            return false;
        }
    }
}
