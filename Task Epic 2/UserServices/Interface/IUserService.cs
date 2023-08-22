namespace ChallengeMe.Tests
{
    public interface IUserService
    {
        void RegisterUser(string username, string password);
        void EnterTheRegister(string username, string password);
        void NotRegisterUser(string username);
    }
}
