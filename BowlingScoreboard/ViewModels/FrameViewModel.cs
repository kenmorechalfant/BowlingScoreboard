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
        private readonly ObservableCollection<ThrowAttemptViewModel> _throws;
        public IEnumerable<ThrowAttemptViewModel> Throws => _throws;

        public FrameViewModel(Frame frame)
        {
            _frame = frame;

            _throws = new ObservableCollection<ThrowAttemptViewModel>();

            foreach (ThrowAttempt throwAttempt in frame.Throws)
            {
                _throws.Add(new ThrowAttemptViewModel(throwAttempt));
            }
        }
    }
}
