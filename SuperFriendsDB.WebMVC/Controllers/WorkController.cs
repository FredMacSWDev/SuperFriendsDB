using SuperFriendsDB.Models.WorkModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    [Authorize]
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index()
        {
            var model = new WorkListItem[0];
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkCreate model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }
    }
}