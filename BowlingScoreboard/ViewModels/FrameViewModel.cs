using BowlingScoreboard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreboard.ViewModels
{
    internal class FrameViewModel : ViewModelBase
    {
        private readonly Frame _frame;
        private readonly ObservableCollection<string> _throws;
        public IEnumerable<string> Throws => _throws;

        public FrameViewModel(Frame frame)
        {
            _throws = new ObservableCollection<string>();
            _frame = frame;

            _throws.Add("");
            _throws.Add("7");
        }
    }
}
