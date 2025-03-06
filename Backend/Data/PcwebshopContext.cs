using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Backend.Data
{
    /// <summary>
    /// Klasa koja predstavlja kontekst baze podataka za aplikaciju Pcwebshop.
    /// </summary>
    public class PcwebshopContext:DbContext
    {
        /// <summary>
        /// Konstruktor klase PcwebshopContext koji prima opcije za konfiguraciju konteksta.
        /// </summary>
        /// <param name="opcije">Opcije za konfiguraciju konteksta.</param>
        public PcwebshopContext(DbContextOptions<PcwebshopContext> opcije) : base(opcije)
        {


        }
        /// <summary>
        /// Skup podataka za entitet Kategorija.
        /// </summary>
        public DbSet<Kategorija> Kategorije { get; set; } // Zbog ovog Kategorije se tablica zove u množini
        /// <summary>
        /// Skup podataka za entitet Korisnik.
        /// </summary>
        public DbSet<Korisnik> Korisnici { get; set; }
        /// <summary>
        /// Skup podataka za entitet Proizvod.
        /// </summary>
        public DbSet<Proizvod> Proizvodi { get; set; }
        /// <summary>
        /// Skup podataka za entitet ListaZelja.
        /// </summary>
        public DbSet<ListaZelja> ListeZelja { get; set; }

        /// <summary>
        /// Konfiguracija modela prilikom kreiranja baze podataka.
        /// </summary>
        /// <param name="modelBuilder">Graditelj modela.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // implementacija veze 1:N Proizvod - Kategorija
            modelBuilder.Entity<Proizvod>().HasOne(g => g.Kategorija);

            // 1:N veza ListaZelja - Korisnik
            modelBuilder.Entity<ListaZelja>()
                .HasOne(l => l.Korisnik);

            // implementacija veze n:n Proizvod - Lista zelja ( stavke )
            modelBuilder.Entity<Proizvod>()
                .HasMany(p => p.ListeZelja)
                .WithMany(k => k.Proizvodi)
                .UsingEntity<Dictionary<string, object>>("stavke",
                s => s.HasOne<ListaZelja>().WithMany().HasForeignKey("lista"),
                s => s.HasOne<Proizvod>().WithMany().HasForeignKey("proizvod"),
                s => s.ToTable("stavke")
                );

        }
    }
}
