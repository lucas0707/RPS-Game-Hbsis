using System;
using System.Collections.Generic;

namespace RPS_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let us play Rock, Paper and Scissors!");
            Console.WriteLine("What is the name of player One?");
            var playerOneName = Console.ReadLine();
            Console.WriteLine(playerOneName + ", What move are you going to make? Type R for Rock, P for Paper and S for Scissors.");
            var playerOneStrategy = Console.ReadLine();
            string[] playerOne = {playerOneName, playerOneStrategy};


            Console.WriteLine("Now, What is the name of player Two?");
            var playerTwoName = Console.ReadLine();
            Console.WriteLine(playerTwoName + ", What move are you going to make? Type R for Rock, P for Paper and S for Scissors.");
            var playerTwoStrategy = Console.ReadLine();
            string[] playerTwo = { playerTwoName, playerTwoStrategy };

            var round = new List<string>();
            round.AddRange(playerOne);
            round.AddRange(playerTwo);

            var game = new Game();
            var winner =  game.rps_game_winner(round);
            Console.WriteLine("The winner is: " + winner.PlayerName + ". Who used the move: " + winner.Strategy);
        }
    }
}
