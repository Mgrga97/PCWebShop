using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class PcwebshopContext:DbContext
    {

        public PcwebshopContext(DbContextOptions<PcwebshopContext>options) : base(options)
        {


        }

        public DbSet<Kategorija> Kategorije { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategorija>().ToTable("Kategorija"); // Map entity to table named "Kategorija"
            base.OnModelCreating(modelBuilder);
        }


    }
}
