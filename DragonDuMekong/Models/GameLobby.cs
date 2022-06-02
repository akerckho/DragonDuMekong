namespace DragonDuMekong.Models
{
    public class GameLobby
    {
        private readonly string _gameName = "Dodanne's Dragon";
        private readonly List<User> _players = new();
        private User _lobbyOwner; // maybe useful later 

        public GameLobby(User owner)
        {
            _lobbyOwner = owner;
            _players.Add(owner);
        }

        public string GameName { get { return _gameName; } }

        public void AddPlayer(User pl)
        {
            if (_players.Count < 6) _players.Add(pl);
            else throw new Exceptions.LobbyFullException("Max number of players already connected");
        } 

        public List<string> GetPlayersName()
        {
            List<string> names = new List<string>();
            foreach (var p in _players) names.Add(p.UserName);
            return names;
        }
    }
}
