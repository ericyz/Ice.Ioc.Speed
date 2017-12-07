using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ice.ioc.speed.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ice.ioc.speed.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceProvider serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;

        }
        [HttpGet("api/ping/1")]
        public IActionResult Index()
        {
            var time = DateTime.Now;
            for (var i = 0; i < 1000; i++)
            {
                var service = serviceProvider.GetService<IMasterService>();
            }
            Console.WriteLine((DateTime.Now - time).ToString());
            
            return Ok();
        }

        [HttpGet("api/ping/2")]
        public IActionResult Test2()
        {
            var time = DateTime.Now;

            for (var i = 0; i < 1000; i++)
            {
                var service = new MasterService(new ChildService1(), new ChildService2(), new ChildService3());
            }
            Console.WriteLine((DateTime.Now - time).ToString());
            return Ok();
        }

    }
}
