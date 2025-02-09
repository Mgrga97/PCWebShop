using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class PcwebshopContext:DbContext
    {

        public PcwebshopContext(DbContextOptions<PcwebshopContext>options) : base(options)
        {


        }

        public DbSet<Kategorije> Kategorije { get; set; }



    }
}
