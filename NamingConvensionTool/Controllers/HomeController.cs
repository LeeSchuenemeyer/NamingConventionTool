using Microsoft.AspNetCore.Mvc;
using NamingConvensionTool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NamingConvensionTool.Controllers
{
    public class HomeController : Controller
    {
        private SolutionContext _dbContext;
        public HomeController(SolutionContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //var myskill = new List<ConvertEnum>();
            //foreach (MySkills lang in Enum.GetValues(typeof(MySkills)))
            //    myskill.Add(new ConvertEnum
            //    {
            //        Value = (int)lang,
            //        Text = lang.ToString()
            //    });
            //ViewBag.MySkillEnum = myskill;

            //List<SelectListItem>

            ViewBag.CountryList = _dbContext.Country.Select(x => new { Value = x.code, Text = x.name }).ToList();
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
