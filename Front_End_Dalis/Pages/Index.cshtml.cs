using Front_End_Dalis.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Front_End_Dalis.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public int VartotojoId { get; set; }

        INuomaAPIService _apiService;

        public IndexModel(ILogger<IndexModel> logger, INuomaAPIService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        public void OnGet()
        {
            Random random = new Random();
            VartotojoId = random.Next(1, 100000);
            _apiService.GetAllAnimals();
        }
    }
}
