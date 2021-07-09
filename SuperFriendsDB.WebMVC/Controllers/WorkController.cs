﻿using Microsoft.AspNet.Identity;
using SuperFriendsDB.Models.WorkModels;
using SuperFriendsDB.Services;
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
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkService(userId);
            var model = service.GetWork();

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateWorkService();

            if (service.CreateWork(model))
            {
                TempData["SaveResult"] = "Your work attributes have been added successfully!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your work attributes could not be created");

            return View(model);
        }

        private WorkService CreateWorkService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkService(userId);
            return service;
        }
    }
}