using Microsoft.EntityFrameworkCore;

namespace NewsAggregator.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Source> Sources => Set<Source>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=sourcesdata.db");
        }
    }
}
