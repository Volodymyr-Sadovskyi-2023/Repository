namespace ChallengeMe.Tests
{
    public interface IUserRegistrationService
    {
        void RegisterUser(string username, string password);
        void UnregisterUser(string username);
    }

    public interface IUserEnterService
    {
        void EnterTheRegister(string username, string password);
    }
}
