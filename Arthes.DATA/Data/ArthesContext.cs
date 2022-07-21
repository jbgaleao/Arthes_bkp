using Arthes.DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Arthes.DATA.Data
{
    public class ArthesContext : DbContext
    {
        public ArthesContext()
        {
        }

        public ArthesContext(DbContextOptions<ArthesContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("ArthesConn");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public virtual DbSet<ModelRevista>? REVISTAS { get; set; }
    }
}
