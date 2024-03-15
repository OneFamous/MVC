using deneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deneme.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "IUC BİLGİSAYAR" };
            return View(movie);
        }
        public ActionResult Edit(int id) 
        {
            return Content("id=" + id);
        
        }
        public ActionResult ByReleasedate(int year, int month) 
        {
            return Content(year + "/" + month);
        }
    }
}