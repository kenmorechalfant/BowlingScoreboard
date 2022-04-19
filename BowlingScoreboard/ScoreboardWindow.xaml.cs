﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BowlingScoreboard.Models;

namespace BowlingScoreboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ScoreboardWindow : Window
    {
        private Game game;

        public ScoreboardWindow()
        {
            InitializeComponent();
            //game = new Game(new List<string> { "Dave", "Mary", "Paul", "Zebulon" });
            game = new Game();
            Console.WriteLine(game.ToString());
        }
    }
}