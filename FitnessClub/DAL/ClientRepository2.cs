using FitnessClub.Data;
using FitnessClub.Interfaces;
using FitnessClub.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.DAL
{
    public class ClientRepository2 : IClientRepository
    {
        private FitnessClubContext context = new FitnessClubContext();

        public ClientRepository2()
        {
            context.Database.Migrate();
        }

        public Client GetById(int id)
        {
            return context.Clients.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Client> GetAll()
        {
            return context.Clients.ToList();
        }

        public void Add(Client entity)
        {
            context.Clients.Add(entity);
            context.SaveChanges();
        }

        public void Update(Client entity)
        {
            context.Clients.Update(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Client client = GetById(id);

            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
            }
        }

        public Client GetByPhone(string phone)
        {
            return context.Clients.FirstOrDefault(c => c.Phone == phone);
        }
    }
}