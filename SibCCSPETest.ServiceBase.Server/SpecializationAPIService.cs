using SibCCSPETest.Data;
using System.Net.Http.Json;

namespace SibCCSPETest.ServiceBase
{
    public class SpecializationAPIService : ISpecializationAPIService
    {
        private readonly HttpClient _httpClient;

        public SpecializationAPIService(IHttpClientFactory httpClienFactory)
        {
            _httpClient = httpClienFactory.CreateClient("HttpClient");
        }

        public async Task<IEnumerable<SpecializationDTO>> GetAllSpecialization()
        {
            try
            {
                var response = await _httpClient.GetAsync("api/specializations");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<SpecializationDTO>>() ?? [];
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return new List<SpecializationDTO>();
            }
        }

        public async Task<SpecializationDTO?> GetSpecialization(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/specializations/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<SpecializationDTO>();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task<SpecializationDTO?> AddSpecialization(SpecializationDTO item)
        {
            try
            {
                using var response = await _httpClient.PostAsJsonAsync("api/specializations", item);
                response.EnsureSuccessStatusCode();
                SpecializationDTO? specialization = await response.Content.ReadFromJsonAsync<SpecializationDTO>();
                return specialization;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateSpecialization(SpecializationDTO item)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/specializations");
                response.EnsureSuccessStatusCode();
                await _httpClient.PutAsJsonAsync("api/specializations", item);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }

        public async Task DeleteSpecialization(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/specializations");
                response.EnsureSuccessStatusCode();
                await _httpClient.DeleteAsync($"api/specializations/{id}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"API Error: {ex.Message}");
            }
        }
    }
}
