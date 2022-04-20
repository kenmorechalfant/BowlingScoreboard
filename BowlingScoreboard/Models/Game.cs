using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreboard.Models
{
    internal class Game
    {
        private int frameCount = 10;
        public int CurrentFrame { get; private set; }

        private List<Frame> _frames;
        public IEnumerable<Frame> Frames {
            get { return _frames; }
            private set
            {
                _frames = (List<Frame>)value;
            }
        }

        public Game()
        {
            CurrentFrame = 0;
            _frames = new List<Frame>();

            for (int i = 0; i < frameCount; i++)
            {
                _frames.Add(new Frame());
            }

            Console.WriteLine($"Frame Count: {_frames.Count}");
        }

        public void Reset()
        {
            foreach (Frame frame in _frames)
            {
                frame.Reset();
            }
        }

        
        public override string ToString()
        {
            return "Game - frameCount: " + frameCount.ToString();
        }
    }
}
