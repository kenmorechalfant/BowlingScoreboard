using BowlingScoreboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreboard.ViewModels
{
    class ThrowAttemptViewModel : ViewModelBase
    {
        private string _result;
        private ThrowAttempt _throwAttempt;

        public string Result
        {
            get { return _result; }
            set
            {
                if (value != _result)
                {
                    _result = value;
                    OnPropertyChanged(nameof(ThrowAttemptViewModel.Result));
                }
            }
        }

        public ThrowAttemptViewModel(ThrowAttempt throwAttempt)
        {
            _throwAttempt = throwAttempt;
        }
    }
}
