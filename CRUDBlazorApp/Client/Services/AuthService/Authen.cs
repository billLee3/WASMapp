using System.Net.Http.Json;

namespace CRUDBlazorApp.Client.Services.AuthService
{
    public class Authen : IAuthen
    {
        private readonly HttpClient _http;

        public Authen(HttpClient http)
        {
            _http = http;
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
