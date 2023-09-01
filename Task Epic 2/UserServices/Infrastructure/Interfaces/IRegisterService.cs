namespace ChallengeMe.Infrastructure.Interfaces
{
    public interface IRegisterService
    {
        void RegisterUser(string username, string password);

        void DeleteUser(string username);

        void Login(string username, string password);
    }
}
