using SibCCSPETest.Data;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class QuestionAPIService : IQuestionAPIService
    {
        private readonly HttpClient _httpClient;

        public QuestionAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<QuestionDTO>> GetAllQuestion()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/questions");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<QuestionDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<QuestionDTO>();
            }
        }

        public async Task<QuestionDTO?> GetQuestion(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/questions/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<QuestionDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<QuestionDTO?> AddQuestion(QuestionDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/questions", item);
                response.EnsureSuccessStatusCode();
                QuestionDTO? question = await response.Content.ReadFromJsonAsync<QuestionDTO>();
                return question;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateQuestion(QuestionDTO item)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/questions");
                response.EnsureSuccessStatusCode();
                await _httpClient.PutAsJsonAsync("api/questions", item);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }

        public async Task DeleteQuestion(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/questions");
                response.EnsureSuccessStatusCode();
                await _httpClient.DeleteAsync($"api/questions/{id}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
