using FitnessClub.Models;

namespace FitnessClub.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByPhone(string phone);
    }
}