using Microsoft.AspNet.Identity;
using SuperFriendsDB.Models.AppearanceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    [Authorize]
    public class AppearanceController : Controller
    {
        // GET: Appearance
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AppearanceService(userId);
            var model = service.GetAppearance();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AppearanceCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            //var service = CreateAppearanceService();

            //if (service.CreateAppearance(model))
            //{
            //    TempData["SaveResult"] = "Your powerstats have been added successfully!";
            //    return RedirectToAction("Index");
            //};

            //ModelState.AddModelError("", "Powerstat could not be created");

            return View(model);
        }
    }
}