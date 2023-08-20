namespace ChallengeMe.CONFIDENT;

    internal static class UsersRegister
    {
        public static void UsersRegistry()
        {
            var user = new User();
            user.SetValues("1", "2");
            Users[0] = user;
          
            return;
        }
        public static User[] Users = new User[1];
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
