using Microsoft.AspNet.Identity;
using SuperFriendsDB.Models.PowerstatModels;
using SuperHeroDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    [Authorize]
    public class PowerstatController : Controller
    {
        // GET: Powerstat
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PowerstatService(userId);
            var model = service.GetPowerstats();
            
            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PowerstatCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreatePowerstatService();

            if (service.CreatePowerstat(model))
            {
                TempData["SaveResult"] = "Your powerstats have been added successfully!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Powerstat could not be created");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var service = CreatePowerstatService();
            var model = service.GetPowerstatById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreatePowerstatService();
            var detail = service.GetPowerstatById(id);
            var model =
                new PowerstatEdit
                {
                    Intelligence = detail.Intelligence,
                    Strength = detail.Strength,
                    Speed = detail.Speed,
                    Durability = detail.Durability,
                    Power = detail.Power,
                    Combat = detail.Combat
                };
            return View(model);
        }

        private PowerstatService CreatePowerstatService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new PowerstatService(userId);
            return service;
        }
    }
}