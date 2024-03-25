using Microsoft.EntityFrameworkCore;
using MVCcumul_01.Models;

namespace MVCcumul_01
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            //var connectionString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServer²Certificate=True";

            //services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(connectionString),
            //    ServiceLifetime.Singleton);

            //services.AddDbContextFactory<NorthwindContext>(
            //   options => options.UseSqlServer(),
            //    lifetime: ServiceLifetime.Singleton);
        }


        public void Configure()
        {
        }


    }
}
