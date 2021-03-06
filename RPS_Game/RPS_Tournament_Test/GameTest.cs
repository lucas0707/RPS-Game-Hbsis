﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS_Game;

namespace RPS_Tournament_Test
{
    [TestClass]
    public class GameTest
    {
        private readonly string[] _playerOne = { "Armando", "P" };
        private readonly string[] _playerTwo = { "Dave", "S" };
        private readonly string[] _playerThree = { "Richard", "R" };
        private readonly string[] _playerFour = { "Michael", "S" };
        private readonly string[] _playerFive = { "David E.", "R" };
        private readonly string[] _playerSix = { "Richard X.", "P" };

        [TestMethod]
        public void GameTestMethodSWin()
        {
            var gameOne = new List<string>();
            gameOne.AddRange(_playerOne);
            gameOne.AddRange(_playerTwo);

            var tournament = new Game();
            var winner = tournament.rps_game_winner(gameOne);
            Assert.AreEqual(_playerTwo[0], winner.PlayerName);
        }

        [TestMethod]
        public void GameTestMethodRWin()
        {
            var gameOne = new List<string>();
            gameOne.AddRange(_playerThree);
            gameOne.AddRange(_playerFour);

            var tournament = new Game();
            var winner = tournament.rps_game_winner(gameOne);
            Assert.AreEqual(_playerThree[0], winner.PlayerName);
        }

        [TestMethod]
        public void GameTestMethodPWin()
        {
            var gameOne = new List<string>();
            gameOne.AddRange(_playerFive);
            gameOne.AddRange(_playerSix);

            var tournament = new Game();
            var winner = tournament.rps_game_winner(gameOne);
            Assert.AreEqual(_playerSix[0], winner.PlayerName);
        }
    }
}
