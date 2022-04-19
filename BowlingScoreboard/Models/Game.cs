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
        private List<Frame> frames;

        public Game()
        {
            CurrentFrame = 0;
            frames = new List<Frame>();

            for (int i = 0; i < frameCount; i++)
            {
                frames.Add(new Frame());
            }
        }

        public override string ToString()
        {
            return "Game - frameCount: " + frameCount.ToString();
        }
    }
}
