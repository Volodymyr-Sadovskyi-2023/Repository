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
