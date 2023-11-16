using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VivesActivities.Ui.Mvc.Core;
using VivesActivities.Ui.Mvc.Models;
using Activity = System.Diagnostics.Activity;

namespace VivesActivities.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly VivesActivitiesDbContext _dbContext;

        public HomeController(VivesActivitiesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var activities = _dbContext.Activities.ToList();
            return View(activities);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
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