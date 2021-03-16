using Microsoft.EntityFrameworkCore;

namespace My_Application.Models.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<File> Files { get; set; }

        public DbSet<Image> Images { get; set; }
        
    }
}