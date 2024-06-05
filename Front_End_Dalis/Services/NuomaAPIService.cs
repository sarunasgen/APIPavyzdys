using APIPavyzdys;

namespace Front_End_Dalis.Services
{
    public class NuomaAPIService : INuomaAPIService
    {
        private readonly string _apiBase;
        public NuomaAPIService(string apibase) 
        { 
            _apiBase = apibase;
        }
        public List<Animal> GetAllAnimals()
        {
            throw new NotImplementedException();
        }
    }
}
