using BowlingScoreboard.Models;
using BowlingScoreboard.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BowlingScoreboard
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Game _game;

        public App()
        {
            _game = new Game();
            Console.WriteLine(_game.ToString());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new ScoreboardWindow()
            {
                DataContext = new ScoreboardViewModel(_game)
            };

            MainWindow.Show();

            base.OnStartup(e);

        }
}
}
