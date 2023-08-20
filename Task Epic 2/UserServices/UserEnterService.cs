namespace ChallengeMe.Tests
{
    public class UserEnterService : IUserEnterService
    {
        private readonly List<User> users;

        public UserEnterService(List<User> users)
        {
            this.users = users;
        }

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
    }
}
