using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Backend.Data
{
    public class PcwebshopContext:DbContext
    {

        public PcwebshopContext(DbContextOptions<PcwebshopContext> opcije) : base(opcije)
        {


        }

        public DbSet<Kategorija> Kategorije { get; set; } // Zbog ovog Kategorije se tablica zove u množini

        public DbSet<Korisnik> Korisnici { get; set; }

        public DbSet<Proizvod> Proizvodi { get; set; }

        public DbSet<ListaZelja> ListeZelja { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // implementacija veze 1:N Proizvod - Kategorija
            modelBuilder.Entity<Proizvod>().HasOne(g => g.Kategorija).WithMany(g => Proizvodi);

            // 1:N veza ListaZelja - Korisnik
            modelBuilder.Entity<ListaZelja>()
                .HasOne(l => l.Korisnik)
                .WithMany(k => k.ListeZelja)
                .HasForeignKey(l => l.Korisnik);

            // implementacija veze n:n Proizvod - Lista zelja ( stavke )
            modelBuilder.Entity<Proizvod>()
                .HasMany(p => p.Kategorije)
                .WithMany(k => k.Proizvodi)
                .UsingEntity<Dictionary<string, object>>("stavke",
                s => s.HasOne<Kategorija>().WithMany().HasForeignKey("lista"),
                s => s.HasOne<Proizvod>().WithMany().HasForeignKey("proizvoda"),
                s => s.ToTable("stavke")
                );

        }
    }
}
