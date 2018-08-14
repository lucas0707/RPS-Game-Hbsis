using System.Collections.Generic;

namespace RPS_Game
{
    public interface IRound
    {
        Play rps_game_winner(List<string> plays);
    }
}
