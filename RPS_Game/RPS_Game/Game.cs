using System.Collections.Generic;

namespace RPS_Game
{
    public class Game : IRound
    {
        public virtual Play rps_game_winner(List<string> listOfPlays)
        {
            if (listOfPlays.Count > 4)
            {
                throw new WrongNumberOfPlayersError("You entered the wrong number of players!");
            }

            var playerOne = new Play(listOfPlays[0], listOfPlays[1]);
            var playerTwo = new Play(listOfPlays[2], listOfPlays[3]);

            Play winner;

            if (playerOne.Strategy != playerTwo.Strategy)
            {
                if (playerOne.Strategy == "R")
                {
                    if (playerTwo.Strategy == "P")
                    {
                        winner = playerTwo;
                        return winner;
                    }
                    winner = playerOne;
                    return winner;
                }

                if (playerOne.Strategy == "P")
                {
                    if (playerTwo.Strategy == "S")
                    {
                        winner = playerTwo;
                        return winner;
                    }
                    winner = playerOne;
                    return winner;
                }

                if (playerOne.Strategy == "S")
                {
                    if (playerTwo.Strategy == "R")
                    {
                        winner = playerTwo;
                        return winner;
                    }
                    winner = playerOne;
                    return winner;
                }
            }

            winner = playerOne;

            return winner;
        }
    }
}
