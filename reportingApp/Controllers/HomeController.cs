using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reportingApp.Models;

namespace reportingApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            using (TestDBEntities db=new TestDBEntities())
            {
                return View(db.sp_getBookNPublisher().ToList());
            }
        }
    }
}