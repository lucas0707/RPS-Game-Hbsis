namespace RPS_Game
{
    public class Play
    {
        public Play()
        {
        }

        public Play(string playerName, string strategy)
        {
            _playerName = playerName;
            _strategy = strategy;
        }

        private string _playerName;
        private string _strategy;

        public string PlayerName { get => _playerName; set => ValidatePlayerName(value); }
        public string Strategy { get => _strategy; set => ValidateStrategy(value); }

        private void ValidateStrategy(string value)
        {
            if (value != "R" && value != "P" && value != "S")
            {
                throw new NoSuchStrategyError("Strategy must be R, P or S.");
            }
            _strategy = value;
        }

        private void ValidatePlayerName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new PlayerNameInvalid("Player Name must not be Empty!");
            }

            _playerName = value;
        }
    }
}
