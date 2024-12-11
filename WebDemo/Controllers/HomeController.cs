using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;
using WebDemo.Data;
using System.Diagnostics;

namespace WebDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly AppDbContext context;

        public HomeController(ILogger<HomeController> logger1, AppDbContext context1)
        {
            logger = logger1;
            context = context1;
        }

        public IActionResult FirstPage()
        {
           return View();
        }
    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
