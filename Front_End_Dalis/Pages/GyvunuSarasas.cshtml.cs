using APIPavyzdys;
using Front_End_Dalis.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Front_End_Dalis.Pages
{
    public class GyvunuSarasasModel : PageModel
    {
        private readonly INuomaAPIService _apiService;
        [BindProperty]
        public List<Animal> Animals { get; set; }
        public GyvunuSarasasModel(INuomaAPIService service) 
        {
            _apiService = service;
        }
        public void OnGet()
        {
            Animals = _apiService.GetAllAnimals();
        }
    }
}
