using SibCCSPETest.Data;
using System.Linq.Expressions;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class GroupAPIService : IGroupAPIService
    {
        private readonly HttpClient _httpClient;

        public GroupAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<GroupDTO>> GetAllGroup()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/groups");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<GroupDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<GroupDTO>();
            }
        }

        public async Task<GroupDTO?> GetGroup(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/groups/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<GroupDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<GroupDTO?> AddGroup(GroupDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/groups", item);
                response.EnsureSuccessStatusCode();
                GroupDTO? group = await response.Content.ReadFromJsonAsync<GroupDTO>();
                return group;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateGroup(GroupDTO item)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/groups");
                response.EnsureSuccessStatusCode();
                await _httpClient.PutAsJsonAsync("api/groups", item);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }

        public async Task DeleteGroup(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/groups");
                response.EnsureSuccessStatusCode();
                await _httpClient.DeleteAsync($"api/groups/{id}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
