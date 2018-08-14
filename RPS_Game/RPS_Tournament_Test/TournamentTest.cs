using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS_Game;
using System.Collections.Generic;

namespace RPS_Tournament_Test
{
    [TestClass]
    public class TournamentTest
    {
        private string[] _playerOne = { "Armando", "P" };
        private string[] _playerTwo = { "Dave", "S" };
        private string[] _playerThree = { "Richard", "R" };
        private string[] _playerFour = { "Michael", "S" };
        private string[] _playerFive = { "Allen", "S" };
        private string[] _playerSix = { "Omer", "P" };
        private string[] _playerSeven = { "David E.", "R" };
        private string[] _playerEight = { "Richard X.", "P" };

        [TestMethod]
        public void TournamentTestMethod()
        {
            var gameOne = new List<string>();
            gameOne.AddRange(_playerOne);
            gameOne.AddRange(_playerTwo);
            gameOne.AddRange(_playerThree);
            gameOne.AddRange(_playerFour);
            gameOne.AddRange(_playerFive);
            gameOne.AddRange(_playerSix);
            gameOne.AddRange(_playerSeven);
            gameOne.AddRange(_playerEight);

            var tournament = new Tournament();
            var winner = tournament.rps_tournament_winner(gameOne);
            Assert.AreEqual(_playerThree[0], winner.PlayerName);
        }
    }

}
