namespace APIPavyzdys.Services
{
    public interface IServiceThatUsesDatabaseActions
    {
        Animal GetAnimalById(int id);
    }
}