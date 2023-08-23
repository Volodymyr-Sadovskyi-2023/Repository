namespace ChallengeMe.Tests
{
    public interface IUserService
    {
        void RegisterUser(string username, string password);
        void CheckRegisterUser(string username, string password);
        void FirstRegisterUser(string username);
    }
}
