namespace ChallengeMe.CONFIDENT;

namespace ChallengeMe.Tests
{
    internal static class UsersRegister
    {
        public static void UsersRegistry()
        {
            var user = new User("1", "2");
            Users[0] = user;
        }

        public static User[] Users = new User[1];
    }
}


