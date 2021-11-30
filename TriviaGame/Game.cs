using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class Game
    {
        private string GametTitleArt = @"  _______   _       _          ____                  _   
 |__   __| (_)     (_)        / __ \                | |  
    | |_ __ ___   ___  __ _  | |  | |_   _  ___  ___| |_ 
    | | '__| \ \ / / |/ _` | | |  | | | | |/ _ \/ __| __|
    | | |  | |\ V /| | (_| | | |__| | |_| |  __/\__ \ |_ 
    |_|_|  |_| \_/ |_|\__,_|  \___\_\\__,_|\___||___/\__|";
        private string GameTitle = "Trivia Quest";
        private string Description = "Battle your friends the top score in silly trivia.";
        private Player CurrentPlayer;
        private TriviaItem UnicornTrivia;
        private TriviaItem OctoTrivia;
        private TriviaItem BleachTrivia;

        public Game()
        {
            string unicornQuestion = "The national animal of Scotland is the Unicorn true or false? ";
            UnicornTrivia = new TriviaItem(unicornQuestion, "true");

            string octoQuestion = "An octopus can fit through any hole larger than its beak true or false?";
            OctoTrivia = new TriviaItem(octoQuestion, "true");

            string bleachTrivia = "Bleach never expires true or false?";
            BleachTrivia = new TriviaItem(bleachTrivia, "false");
        }

        public void Play()
        {
            Console.Title = GameTitle;

            Console.WriteLine(GametTitleArt);
            Console.WriteLine("");
            Console.WriteLine($"Welcome to {GameTitle}");
            Console.WriteLine(Description);

            Console.Write("\nWhat is your name: ");
            string playerName = Console.ReadLine();
            CurrentPlayer = new Player(playerName);
            Console.WriteLine($"Welcome to {GameTitle}, {CurrentPlayer.Name}!");

            Console.WriteLine("\n==========================================================================");
            UnicornTrivia.AskQuestion();
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\n==========================================================================");
            OctoTrivia.AskQuestion();
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\n==========================================================================");
            BleachTrivia.AskQuestion();
            Console.WriteLine("==========================================================================");

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();

        }
    }
}
