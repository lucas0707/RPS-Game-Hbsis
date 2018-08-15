using System.Collections.Generic;

namespace RPS_Game
{
    public class Tournament : Game
    {
        private Game round = new Game();

        public override Play rps_game_winner(List<string> plays)
        {
            return base.rps_game_winner(plays);
        }

        public Play rps_tournament_winner(List<string> players)
        {
            if (players.Count / 2 % 2 != 0)
            {
                throw new WrongNumberOfPlayersError("Number of players is invalid.");
            }

            var numberOfPlayers = players.Count / 2;

            while (numberOfPlayers > 1)
            {
                for (int i = 0; i < numberOfPlayers; i += 2)
                {
                    var roundPlayers = new List<string>(); ;
                    roundPlayers.Add(players[i]);
                    roundPlayers.Add(players[i + 1]);
                    roundPlayers.Add(players[i + 2]);
                    roundPlayers.Add(players[i + 3]);
                    var winner = round.rps_game_winner(roundPlayers);

                    if (winner.PlayerName == players[i])
                    {
                        players.RemoveAt(i + 2);
                        players.RemoveAt(i + 2);
                        continue;
                    }

                    players.RemoveAt(i);
                    players.RemoveAt(i);
                }

                numberOfPlayers = players.Count / 2;
            }

            return new Play{PlayerName = players[0], Strategy = players[1]};
        }
    }

}
