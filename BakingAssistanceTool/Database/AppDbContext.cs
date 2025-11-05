using Microsoft.EntityFrameworkCore;
using BakingAssistanceTool.EF_Models;

namespace BakingAssistanceTool.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test2> Tests2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // This creates/uses a file named myapp.db in the project folder
            options.UseSqlite("Data Source=Database/myapp.db");
        }
    }
}
