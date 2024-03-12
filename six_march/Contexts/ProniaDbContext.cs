using Microsoft.EntityFrameworkCore;
using six_march.Models;

namespace six_march.Contexts
{
    public class ProniaDbContext : DbContext
    {
        internal object categories;

        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {
        }

        public DbSet<Slider>? Sliders { get; set; }

        public DbSet<Shipping>? Shippings { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}