namespace APIPavyzdys.Services
{
    public class DatabaseActionsService : IDatabaseActionsService
    {
        string _databaseConnection;
        public DatabaseActionsService(string databaseConnection) 
        {
            _databaseConnection = databaseConnection;
        }

        public Animal FetchAnimalById(int id)
        {
            return new Animal { Name = "Becky" };
        }
    }
}
