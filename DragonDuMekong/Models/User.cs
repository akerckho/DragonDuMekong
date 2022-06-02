namespace DragonDuMekong.Models
{
    public class User
    {
        private string _username;
        public User(string username)
        {
            _username = username;
        }
        public string UserName { get { return _username; } } 
    }
}
