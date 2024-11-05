using _2307cb1.Model;
using Microsoft.EntityFrameworkCore;

namespace _2307cb1.Data
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DB2307.db");
        }
    }
}
