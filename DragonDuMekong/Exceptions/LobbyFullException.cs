namespace DragonDuMekong.Exceptions
{
    public class LobbyFullException : Exception
    {
        public LobbyFullException()
        {
        }

        public LobbyFullException(string message)
            : base(message)
        {
        }

        public LobbyFullException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
