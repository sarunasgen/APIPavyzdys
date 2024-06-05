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
        [HttpGet("GetAnimal")]
        public Animal Index()
        {
            return _animalService.GetAnimal();
        }
        [HttpGet("GetAllAnimals")]
        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal { Name = "Lucky", Age = 12});
            animals.Add(new Animal { Name = "Becky", Age = 5 });
            animals.Add(new Animal { Name = "Rocky", Age =7 });
            return animals;
        }
        [HttpPost("InsertAnimal")]
        public void InsertAnimal([FromForm]Animal animal)
        {
            _animalService.InsertAnimal(animal);
        }
        
    }
}
