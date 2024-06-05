using APIPavyzdys;
using System.Text.Json;

namespace Front_End_Dalis.Services
{
    public class NuomaAPIService : INuomaAPIService
    {
        private readonly string _apiBase;
        private readonly HttpClient _httpClient;
        public NuomaAPIService(string apibase) 
        { 
            _apiBase = apibase;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_apiBase);
        }
        public List<Animal> GetAllAnimals()
        {
            string path = "api/Animal/GetAllAnimals";
            HttpResponseMessage response = _httpClient.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<List<Animal>>(jsonResponse);
            }
            return new List<Animal>();
        }

    }
}
