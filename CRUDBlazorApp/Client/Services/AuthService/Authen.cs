using System.Net.Http.Json;

//Code developed by following allow with following course: https://www.udemy.com/course/blazor-ecommerce/learn/
namespace CRUDBlazorApp.Client.Services.AuthService
{
    public class Authen : IAuthen
    {
        private readonly HttpClient _http;

        public Authen(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<bool>> ChangePassword(ChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/authenticate/change-password", request.Password);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var results = await _http.PostAsJsonAsync("api/authenticate/login", request);
            return await results.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var results = await _http.PostAsJsonAsync("api/authenticate/register", request);
            return await results.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
