using BowlingScoreboard.Commands;
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
        public Game Game { get; private set; }

        public string Foo { get; set; } // TODO: remove

        public ScoreboardViewModel(Game game)
        {
            Game = game;

            Foo = "foo"; // TODO: remove

            _frames = new ObservableCollection<FrameViewModel>();

            _frames.Add(new FrameViewModel(new Frame()));
            _frames.Add(new FrameViewModel(new Frame()));
            _frames.Add(new FrameViewModel(new Frame()));

            ResetCommand = new ResetCommand(this, game);
        }
    }
}
