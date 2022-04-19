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

        public Game()
        {
            CurrentFrame = 0;
        }
        public override string ToString()
        {
            return "Game - Current Frame: " + CurrentFrame.ToString();
        }
    }
}
