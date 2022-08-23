using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
    public class HomeController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            public string GetCulture(string code = "")
            {
                if (!String.IsNullOrEmpty(code))
                {
                    CultureInfo.CurrentCulture = new CultureInfo(code);
                    CultureInfo.CurrentUICulture = new CultureInfo(code);
                }
                return $"CurrentCulture:{CultureInfo.CurrentCulture.Name}, CurrentUICulture:{CultureInfo.CurrentUICulture.Name}";
            }
        }
    }
}
//public class Program
//    {
//        public static void Main(string[] args)
//        {
//            CreateHostBuilder(args).Build().Run();
//        }

//        public static IHostBuilder CreateHostBuilder(string[] args) =>
//            Host.CreateDefaultBuilder(args)
//                .ConfigureWebHostDefaults(webBuilder =>
//                {
//                    webBuilder.UseStartup<Startup>();
//                });
