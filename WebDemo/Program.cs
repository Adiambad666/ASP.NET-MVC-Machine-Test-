using Microsoft.EntityFrameworkCore;
using WebDemo.Data;

namespace WebDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

          
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

           
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            
            app.MapControllerRoute(
                name: "product",
                pattern: "Product/{action=Index}/{id?}",
                defaults: new { controller = "Product" });

            app.MapControllerRoute(
                name: "category",
                pattern: "Category/{action=Index}/{id?}",
                defaults: new { controller = "Category" });


        
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=FirstPage}/{id?}");

            app.Run();
        }
    }
}
