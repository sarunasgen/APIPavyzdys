using APIPavyzdys.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIPavyzdys.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;
        public AnimalController(IAnimalService animalService) 
        {
            _animalService= animalService;
        }
        [HttpGet(Name = "GetAnimal")]
        public Animal Index()
        {
            return _animalService.GetAnimal();
        }
    }
}
