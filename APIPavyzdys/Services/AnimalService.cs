namespace APIPavyzdys.Services
{
    public class AnimalService : IAnimalService
    {
        public AnimalService() 
        {
        }

        public Animal GetAnimal()
        {
            return new Animal { Name = "Lucky" };
        }

        public void InsertAnimal(Animal animal)
        {
            animal = animal;
        }
    }
}
