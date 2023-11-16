using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using VivesActivities.Ui.Mvc.Core;
using VivesActivities.Ui.Mvc.Models;

namespace VivesActivities.Ui.Mvc.Controllers
{
    public class VivesActivitiesController : Controller
    {
        private readonly VivesActivitiesDbContext _dbContext;
        public VivesActivitiesController(VivesActivitiesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var activities = _dbContext.Activities.ToList();
            return View(activities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VivesActivity activity)
        {
            if (!ModelState.IsValid)
            {
                return View(activity);
            }

            _dbContext.Activities.Add(activity);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var activity = _dbContext.Activities
                .FirstOrDefault(a => a.Id == id);

            if (activity is null)
            {
                return RedirectToAction("Index");
            }

            return View(activity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VivesActivity activity)
        {
            if (!ModelState.IsValid)
            {
                return View(activity);
            }

            var dbActivity = _dbContext.Activities
                .FirstOrDefault(a => a.Id == activity.Id);

            if (dbActivity is null)
            {
                return RedirectToAction("Index");
            }

            dbActivity.Name = activity.Name;
            dbActivity.Description = activity.Description;
            dbActivity.Type = activity.Type;
            dbActivity.Location = activity.Location;

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
