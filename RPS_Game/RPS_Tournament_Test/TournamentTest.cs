using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS_Game;
using System.Collections.Generic;

namespace RPS_Tournament_Test
{
    [TestClass]
    public class TournamentTest
    {
        private readonly string[] _playerOne = { "Armando", "P" };
        private readonly string[] _playerTwo = { "Dave", "S" };
        private readonly string[] _playerThree = { "Richard", "R" };
        private readonly string[] _playerFour = { "Michael", "S" };
        private readonly string[] _playerFive = { "Allen", "S" };
        private readonly string[] _playerSix = { "Omer", "P" };
        private readonly string[] _playerSeven = { "David E.", "R" };
        private readonly string[] _playerEight = { "Richard X.", "P" };

        [TestMethod]
        public void TournamentTestMethod()
        {
            var games = new List<string>();
            games.AddRange(_playerOne);
            games.AddRange(_playerTwo);
            games.AddRange(_playerThree);
            games.AddRange(_playerFour);
            games.AddRange(_playerFive);
            games.AddRange(_playerSix);
            games.AddRange(_playerSeven);
            games.AddRange(_playerEight);

            var tournament = new Tournament();
            var winner = tournament.rps_tournament_winner(games);
            Assert.AreEqual(_playerThree[0], winner.PlayerName);
        }

        [TestMethod]
        public void TournamentTestMethodFail()
        {
            try
            {
                var games = new List<string>();
                games.AddRange(_playerOne);
                games.AddRange(_playerTwo);
                games.AddRange(_playerThree);

                var tournament = new Tournament();
                var winner = tournament.rps_tournament_winner(games);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Number of players is invalid.");
            }
        }
    }
}
