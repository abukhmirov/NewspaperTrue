using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperTrue
{
    public class NewsPaperTrueContext : DbContext
    {
        public DbSet<Reporter> Reporters { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=password123;Database=Newspaper";
            optionsBuilder.UseNpgsql(connectionString)
                .UseSnakeCaseNamingConvention();
        }
    }
    
    
}
