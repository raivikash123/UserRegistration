using FirstApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Data
{
    public class FirstApiDbContext:DbContext
    {
        public FirstApiDbContext(DbContextOptions<FirstApiDbContext> options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
