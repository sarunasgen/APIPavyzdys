using APIPavyzdys.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace APIPavyzdys.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DatabaseActionsController : ControllerBase
    {
        private readonly IServiceThatUsesDatabaseActions _service;
        public DatabaseActionsController(IServiceThatUsesDatabaseActions service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Animal> Index(int id, int klientoId)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(_service.GetAnimalById(id));
            animals.Add(_service.GetAnimalById(klientoId));
            return animals;
        }
        [HttpPost("CreateAnimal")]
        public List<Animal> Index2(int id, int klientoId)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(_service.GetAnimalById(id));
            animals.Add(_service.GetAnimalById(klientoId));
            return animals;
        }
        [HttpPost]
        public string DisplayListFromJson(string json)
        {
            List<Animal> list = JsonSerializer.Deserialize<List<Animal>>(json);
            list.Add(new Animal { Name = "Another Dogs Name" });

            return JsonSerializer.Serialize(list);
        }
    }
}
