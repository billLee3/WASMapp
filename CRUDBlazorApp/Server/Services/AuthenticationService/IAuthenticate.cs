namespace CRUDBlazorApp.Server.Services.AuthenticationService
{
    public interface IAuthenticate
    {
        Task<ServiceResponse<int>> Register(User user,  string password);
        Task<bool> UserExists(string email);
        Task<ServiceResponse<string>> Login(string email, string password);
    }
}
