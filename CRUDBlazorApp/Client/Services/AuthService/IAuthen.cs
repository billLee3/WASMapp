namespace CRUDBlazorApp.Client.Services.AuthService
{
    public interface IAuthen
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);

    }
}
