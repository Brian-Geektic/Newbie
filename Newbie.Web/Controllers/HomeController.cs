using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newbie.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Newbie.Repositories.Data;
using Newbie.Repositories.Models;


namespace Newbie.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewbiedbContext _context;

        public HomeController(ILogger<HomeController> logger, NewbiedbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Article art = _context.Articles.FirstOrDefault();
            return View(art);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
