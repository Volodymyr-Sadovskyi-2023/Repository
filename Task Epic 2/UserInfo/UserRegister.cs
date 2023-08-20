namespace ChallengeMe.CONFIDENT;

    internal static class UsersRegister
    {
        public static void UsersRegistry()
        {
            var user = new User();
            var user = new User("1", "2");
            Users.Add(user);
          
            return;
        }
        public static List<User> Users = new List<User>();
    }

    internal class User
    {
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get;}
        public string Password { get;}
    }
