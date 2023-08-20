using ChallengeMe.CONFIDENT;

namespace ChallengeMe.Tests
{
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly List<User> users = new List<User>();

        public void RegisterUser(string username, string password)
        {
            users.Add(new User(username, password));
        }

        public void UnregisterUser(string username)
        {
            var userToRemove = users.FirstOrDefault(u => u.Username == username);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
        }
    }
}
