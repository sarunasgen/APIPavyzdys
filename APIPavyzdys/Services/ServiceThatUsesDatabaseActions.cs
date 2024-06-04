namespace APIPavyzdys.Services
{
    public class ServiceThatUsesDatabaseActions : IServiceThatUsesDatabaseActions
    {
        IDatabaseActionsService service;
        public ServiceThatUsesDatabaseActions(IDatabaseActionsService actionsService) 
        {
            service = actionsService;
        }

        public Animal GetAnimalById(int id)
        {
            return service.FetchAnimalById(id);
        }
    }
}
