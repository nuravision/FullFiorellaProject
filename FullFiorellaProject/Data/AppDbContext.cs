using FullFiorellaProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FullFiorellaProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet <SliderInfo> SliderInfos   { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsImages> ProductsImages { get; set; }
        public DbSet<AboutVideo> AboutVideos { get; set; }
        public DbSet<AboutTitles> AboutTitles { get; set; }
        public DbSet<IconTitle> IconTitles { get; set; }
        public DbSet<FlowerExperts> FlowerExperts { get; set; }
        public DbSet<Experts> Experts { get; set; }
    }
}
