namespace APIPavyzdys.Services
{
    public interface IAnimalService
    {
        Animal GetAnimal();
        void InsertAnimal(Animal animal);
    }
}