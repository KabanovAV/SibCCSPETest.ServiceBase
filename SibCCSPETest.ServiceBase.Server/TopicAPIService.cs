using SibCCSPETest.Data;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class TopicAPIService : ITopicAPIService
    {
        private readonly HttpClient _httpClient;

        public TopicAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<TopicDTO>> GetAllTopic()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/topics");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<TopicDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<TopicDTO>();
            }
        }

        public async Task<TopicDTO?> GetTopic(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/topics/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<TopicDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<TopicDTO?> AddTopic(TopicDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/topics", item);
                response.EnsureSuccessStatusCode();
                TopicDTO? topic = await response.Content.ReadFromJsonAsync<TopicDTO>();
                return topic;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateTopic(TopicDTO item)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/topics");
                response.EnsureSuccessStatusCode();
                await _httpClient.PutAsJsonAsync("api/topics", item);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }

        public async Task DeleteTopic(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/topics");
                response.EnsureSuccessStatusCode();
                await _httpClient.DeleteAsync($"api/topics/{id}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
