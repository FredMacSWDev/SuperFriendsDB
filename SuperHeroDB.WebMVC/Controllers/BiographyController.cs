using SuperFriendsDB.Models.BiographyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    [Authorize]
    public class BiographyController : Controller
    {
        // GET: Biography
        public ActionResult Index()
        {
            var model = new BiographyListItem[0];

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (BiographyCreate model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }
    }
}