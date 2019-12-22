using LtBookingSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LtBookingSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FacebookEvent> FacebookEvents { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<MedicalDetails> MedicalDetails { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}
