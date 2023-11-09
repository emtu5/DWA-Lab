using Microsoft.EntityFrameworkCore;
using daw_lab4.Models;

namespace daw_lab4.ContextModels
{
    public class StiriContext : DbContext
    {
        public DbSet<Stire> Stire { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public StiriContext(DbContextOptions<StiriContext> options) : base(options)
        {
        }
    }
}
