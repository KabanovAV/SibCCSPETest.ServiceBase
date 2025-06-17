using SibCCSPETest.Data;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class AnswerAPIService : IAnswerAPIService
    {
        private readonly HttpClient _httpClient;

        public AnswerAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<AnswerDTO>> GetAllAnswer()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/answers");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<AnswerDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<AnswerDTO>();
            }
        }

        public async Task<AnswerDTO?> GetAnswer(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/answers/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<AnswerDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<AnswerDTO?> AddAnswer(AnswerDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/answers", item);
                response.EnsureSuccessStatusCode();
                AnswerDTO? answer = await response.Content.ReadFromJsonAsync<AnswerDTO>();
                return answer;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateAnswer(AnswerDTO item)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/answers");
                response.EnsureSuccessStatusCode();
                await _httpClient.PutAsJsonAsync("api/answers", item);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }

        public async Task DeleteAnswer(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/answers");
                response.EnsureSuccessStatusCode();
                await _httpClient.DeleteAsync($"api/answers/{id}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
