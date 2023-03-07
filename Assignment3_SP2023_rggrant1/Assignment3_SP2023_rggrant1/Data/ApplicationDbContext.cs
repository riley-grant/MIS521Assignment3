using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment3_SP2023_rggrant1.Models;

namespace Assignment3_SP2023_rggrant1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Assignment3_SP2023_rggrant1.Models.Movie> Movie { get; set; }
        public DbSet<Assignment3_SP2023_rggrant1.Models.Actor> Actor { get; set; }
        public DbSet<Assignment3_SP2023_rggrant1.Models.MovieActor> MovieActor { get; set; }
    }
}