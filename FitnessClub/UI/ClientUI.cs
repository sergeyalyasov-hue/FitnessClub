using FitnessClub.BLL;

namespace FitnessClub.UI
{
    public class ClientUI
    {
        public void Start()
        {
            ClientService service = new ClientService();
            service.AddClient();
        }
    }
}