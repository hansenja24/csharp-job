using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewJobs.Models;


namespace NewJobs.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/jobs")]
        public ActionResult JobsList()
        {
          List<Jobs> allJobs = Jobs.GetAll();
          return View(allJobs);
        }

        // [HttpGet("/jobs/new")]
        // public ActionResult JobForm()
        // {
        //   return View();
        // }

        [HttpPost("/jobs")]
        public ActionResult AddJob()
        {
          Jobs newJobs = new Jobs(Request.Form["new-employer"], Request.Form["new-position"], Request.Form["new-address"], Request.Form["new-experience"], Request.Form["new-wage"]);
          List<Jobs> allJobs = Jobs.GetAll();
          return View("JobsList", allJobs);
        }

        [HttpGet("/jobs/{id}")]
        public ActionResult JobDetail(int id)
        {
          Jobs newJobs = Jobs.Find(id);
          return View(newJobs);
        }

        [HttpPost("jobs/list/clear")]
        public ActionResult JobListClear()
        {
          Jobs.ClearAll();
          return View();
        }
    }
}
