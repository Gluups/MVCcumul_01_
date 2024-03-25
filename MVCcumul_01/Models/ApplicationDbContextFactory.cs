using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace MVCcumul_01.Models
{
    internal class ApplicationDbContextFactory : IDesignTimeDbContextFactory<NorthwindContext>
    {
        NorthwindContext IDesignTimeDbContextFactory<NorthwindContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<NorthwindContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new NorthwindContext(builder.Options);
        }
    }
}
