using Microsoft.AspNet.Identity;
using SuperFriendsDB.Models.BiographyModels;
using SuperFriendsDB.Services;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BiographyService(userId);
            var model = service.GetBio();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BiographyCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateBioService();

            if (service.CreateBio(model))
            {
                TempData["SaveResult"] = "The biography has been added successfully!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Bio could not be created");
            return View(model);
        }

        private BiographyService CreateBioService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BiographyService(userId);
            return service;
        }
    }
}