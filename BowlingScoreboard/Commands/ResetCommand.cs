using BowlingScoreboard.Models;
using BowlingScoreboard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BowlingScoreboard.Commands
{
    internal class ResetCommand : CommandBase
    {
        private readonly ScoreboardViewModel _scoreboardViewModel;
        private readonly Game _game;

        public ResetCommand(ScoreboardViewModel scoreboardViewModel, Game game)
        {
            _scoreboardViewModel = scoreboardViewModel;
            _game = game;
        }

        public override void Execute(object parameter)
        {
            _scoreboardViewModel.Foo = "reset";
            MessageBox.Show("Reset", "Info");
        }
    }
}
