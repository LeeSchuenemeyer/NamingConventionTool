using Microsoft.AspNetCore.Mvc;
using NamingConvensionTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamingConvensionTool.Controllers
{
    public class CountryController : Controller
    {
        private SolutionContext _dbContext;
        public CountryController(SolutionContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.CountryList = _dbContext.Country.Select(x => new { Id = x.id, Name = x.name }).Distinct().ToList();
            return View();
        }
    }
}
