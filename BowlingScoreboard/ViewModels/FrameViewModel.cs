using BowlingScoreboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreboard.ViewModels
{
    internal class FrameViewModel : ViewModelBase
    {
        private readonly Frame _frame;

        public string Score => _frame.Score;

        public FrameViewModel(Frame frame)
        {
            _frame = frame;
        }
    }
}
