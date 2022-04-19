using BowlingScoreboard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BowlingScoreboard.ViewModels
{
    internal class ScoreboardViewModel : ViewModelBase
    {
        private readonly ObservableCollection<FrameViewModel> _frames;
        public IEnumerable<FrameViewModel> Frames => _frames;
        public ICommand ResetCommand { get; }

        public ScoreboardViewModel()
        {
            _frames = new ObservableCollection<FrameViewModel>();

            _frames.Add(new FrameViewModel(new Frame(5)));
            _frames.Add(new FrameViewModel(new Frame(4)));
            _frames.Add(new FrameViewModel(new Frame(3)));
        }
    }
}
