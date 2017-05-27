namespace Yuvia.Domain.Services.Repositories
{
    public interface IUserAccountRepository
    {
        bool CheckUsernameExists(string username);
        bool CheckEmailExists(string email);
        int Register( UserAccount userAccount );
        UserAccount Authenticate(string username, string password, SignIn signIn);
    }
}
