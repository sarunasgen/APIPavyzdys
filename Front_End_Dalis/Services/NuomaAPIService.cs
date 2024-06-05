using APIPavyzdys;
using System.Text.Json;

namespace Front_End_Dalis.Services
{
    public class NuomaAPIService : INuomaAPIService
    {
        private readonly string _apiBase;
        private readonly HttpClient _httpClient;
        private JsonSerializerOptions jsonSerializerOptions;
        public NuomaAPIService(string apibase) 
        { 
            _apiBase = apibase;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_apiBase);
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false
            };
        }
        public List<Animal> GetAllAnimals()
        {
            string path = "api/Animal/GetAllAnimals";
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<List<Animal>>(jsonResponse, jsonSerializerOptions);
            }
            return new List<Animal>();
        }

    }
}
