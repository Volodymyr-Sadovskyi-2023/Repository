using ChallengeMe.CONFIDENT;

namespace ChallengeMe.Tests
{
    public class UserEnter : UserService
    {
        public void EnterTheRegister(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(string username, string password)
        {
            UsersRegister.Users.Append(new User());
        }

        public void NotRegisterUser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
