using Microsoft.AspNetCore.Hosting;
using MVCcumul_01;
using MVCcumul_01.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

// EF Core uses this method at design time to access the DbContext
static IHostBuilder CreateHostBuilder(string[] args)
    => Host.CreateDefaultBuilder(args)
//.ConfigureWebHostDefaults(
//            webBuilder => webBuilder.UseStartup<Startup>());
;

var connectionString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=True;TrustServer Certificate=True";


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services
   .AddDbContextFactory<NorthwindContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
