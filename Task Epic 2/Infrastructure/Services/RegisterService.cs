using ChallengeMe.Data;
using ChallengeMe.Infrastructure.Interfaces;
using System.Threading.Channels;

namespace ChallengeMe.Infrastructure.Services
{
    public class RegisterService : IRegisterService
    {
        private FakingUserData _userData = new FakingUserData();
        public void RegisterUser(string username, string password)
        {
            Console.WriteLine($"something like registration-{username}-{password}");
        }


        public void DeleteUser(string username)
        {
            var user = _userData.Users.Where(x => x.Username == username).FirstOrDefault();

            if (user != null) 
            {
                _userData.Users.Remove(user);
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public void Login(string username, string password)
        {
            var user = _userData.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                Console.WriteLine("You have entered " + user.Username);
            }
            else
            {
                Console.WriteLine("You have not registered");
            }
        }
    }
}

