using FitnessClub.DAL;

namespace FitnessClub.BLL
{
    public class ClientService
    {
        public void AddClient()
        {
            ClientRepository repository = new ClientRepository();
            repository.SaveClient();
        }
    }
}