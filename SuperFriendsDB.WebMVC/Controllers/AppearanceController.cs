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
            var model = service.GetLooksById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateAppearanceService();
            var detail = service.GetLooksById(id);
            var model =
                new AppearanceEdit
                {
                    AppearanceId = detail.AppearanceId,
                    Gender = detail.Gender,
                    Race = detail.Race,
                    Height = detail.Height,
                    Weight = detail.Weight,
                    EyeColor = detail.EyeColor,
                    HairColor = detail.HairColor
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AppearanceEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.AppearanceId != id)
            {
                ModelState.AddModelError("", "ID Mismatch.  Please try again...");
                return View(model);
            }

            var service = CreateAppearanceService();

            if (service.UpdateLooks(model))
            {
                TempData["SaveResult"] = "Congratulations!  The appearance attributes have been successfully updated!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "The appearance attributes could not be updated");

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