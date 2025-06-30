using Microsoft.EntityFrameworkCore;
using Fuelled.ClientTracker.Models;
namespace Fuelled.ClientTracker.Api.Data
{
    public class ClientTrackerDbContext : DbContext
    {
        public ClientTrackerDbContext(DbContextOptions<ClientTrackerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 1, Name = "Hack The Box", Email = "john.doe@example.com", StartDate = DateTime.Now, RenewalDate = DateTime.Now.AddYears(1) },
                new Client { Id = 2, Name = "Forward Pursuit", Email = "jane.smith@example.com", StartDate = DateTime.Now, RenewalDate = DateTime.Now.AddYears(1) }
            );
        }

        public DbSet<Client> Clients { get; set; }
    }
}