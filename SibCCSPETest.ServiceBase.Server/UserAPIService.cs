using SibCCSPETest.Data;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class UserAPIService : IUserAPIService
    {
        private readonly HttpClient _httpClient;

        public UserAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<UserDTO>> GetAllUser()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/users");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<UserDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<UserDTO>();
            }
        }

        public async Task<UserDTO?> GetUser(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/users/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<UserDTO?> AddUser(UserDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/users", item);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<UserDTO>(); ;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<UserDTO?> UpdateUser(UserDTO item)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("api/users", item);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task DeleteUser(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"api/users/{id}");
                response.EnsureSuccessStatusCode();                
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
