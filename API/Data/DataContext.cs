using Microsoft.EntityFrameworkCore;
using SoulmateSeeker.Entities;

namespace SoulmateSeeker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
    }
}
