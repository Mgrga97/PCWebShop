using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class PcwebshopContext:DbContext
    {

        public PcwebshopContext(DbContextOptions<PcwebshopContext>options) : base(options)
        {


        }

        public DbSet<Kategorija> Kategorije { get; set; } // Zbog ovog Kategorije se tablica zove u množini

        public DbSet<Korisnik> Korisnici { get; set; }

    }
}
