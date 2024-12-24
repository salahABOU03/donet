using Biblio;
using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Inscrit> Inscrit { get; set; }
        public DbSet<Livre> Livre { get; set; }
        public DbSet<Pays> Pays { get; set; }
        public DbSet<TypesLivre> TypeLivre { get; set; }
        public DbSet<Emprunt> Emprunt { get; set; }
        public DbSet<Employe> Employe { get; set; }
        public DbSet<Confirmation> Confirmation { get; set; }
        public DbSet<Auteur> Auteur { get; set; }

    }
}
