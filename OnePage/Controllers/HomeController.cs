using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnePage.DAL;
using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _sql;

        public HomeController(AppDbContext sql)
        {
            _sql = sql;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
