using Microsoft.EntityFrameworkCore;
using WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Models;

namespace WebApi_Basil_Ahmed_Abdellah_Ibrahim_0522002_Senior4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
    }
}
