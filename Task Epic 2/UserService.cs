using ChallengeMe.CONFIDENT;

namespace ChallengeMe.Tests
{
    public class UserService : IUserService
    {
        private readonly List<User> users = new List<User>();

        public void EnterTheRegister(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("You have entered " + user.Username);
            }
            else
            {
                Console.WriteLine("You have not registered");
            }
        }

        public void RegisterUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void UnregisterUser(string username)
        {
           UsersRegister.Users[0] = null;
        }
    }
}
