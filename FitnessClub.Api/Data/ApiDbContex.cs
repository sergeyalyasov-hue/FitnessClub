using FitnessClub.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessClub.Api.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }
    }
}