using FitnessClub.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Data
{
    public class FitnessClubContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Membership> Memberships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=fitnessclub.db");
        }
    }
}