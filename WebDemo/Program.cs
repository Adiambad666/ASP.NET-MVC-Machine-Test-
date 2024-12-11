using Microsoft.EntityFrameworkCore;
using WebDemo.Data;

namespace WebDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure DbContext with SQL Server
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Add controllers and views
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Map controller routes
            app.MapControllerRoute(
                name: "product",
                pattern: "Product/{action=Index}/{id?}",
                defaults: new { controller = "Product" });

            app.MapControllerRoute(
                name: "category",
                pattern: "Category/{action=Index}/{id?}",
                defaults: new { controller = "Category" });


            // Default route for the application
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=FirstPage}/{id?}");

            app.Run();
        }
    }
}
