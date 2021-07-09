using Microsoft.AspNet.Identity;
using SuperFriendsDB.Models.AppearanceModels;
using SuperFriendsDB.Services;
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
            var model = service.GetLooks();

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
            
            var service = CreateAppearanceService();
            
            if (service.CreateLook(model))
            {
                TempData["SaveResult"] = "Your appearance attributes have been added successfully!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "The appearance attributes could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreateAppearanceService();
            var model = service.GetAppearanceById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePowerstatService();
            var detail = service.GetPowerstatById(id);
            var model =
                new PowerstatEdit
                {
                    StatsId = detail.StatsId,
                    Intelligence = detail.Intelligence,
                    Strength = detail.Strength,
                    Speed = detail.Speed,
                    Durability = detail.Durability,
                    Power = detail.Power,
                    Combat = detail.Combat
                };
            return View(model);
        }

        private AppearanceService CreateAppearanceService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new AppearanceService(userId);
            return service;
        }
    }
}