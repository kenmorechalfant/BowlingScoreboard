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
        protected int maxThrowCount;
        protected int pinCount = 10;
        private int pinsRemaining;

        private List<ThrowAttempt> _throws;
        public IEnumerable<ThrowAttempt> Throws
        {
            get { return _throws; }
            private set
            {
                _throws = (List<ThrowAttempt>)value;
            }
        }

        public Frame(int throwCount = 2)
        {
            if (throwCount != 2 && throwCount != 3) throw new Exception("A frame can only have 2 or 3 throws.");

            maxThrowCount = throwCount;
            pinsRemaining = pinCount;

            _throws = new List<ThrowAttempt>();

            for (int i = 0; i < maxThrowCount; i++)
            {
                _throws.Add(new ThrowAttempt());
            }

            Console.WriteLine($"Throw Count: {_throws.Count}");
        }
        public void Reset()
        {
            foreach (ThrowAttempt throwAttempt in _throws)
            {
                throwAttempt.Reset();
            }
        }


        public string Score {
            //get { return Throws.Aggregate(0, (acc, x) => acc + x.HitCount); }
            get { return ""; } // TODO
        }
    }
}
