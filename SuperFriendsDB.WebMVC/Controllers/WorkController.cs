using Microsoft.AspNet.Identity;
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

        public ActionResult Details(int id)
        {
            var service = CreateWorkService();
            var model = service.GetWorkById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateWorkService();
            var detail = service.GetWorkById(id);
            var model =
                new WorkEdit
                {
                    WorkId = detail.WorkId,
                    Occupation = detail.Occupation,
                    Base = detail.Base
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, WorkEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.WorkId != id)
            {
                ModelState.AddModelError("", "ID Mismatch.  Please try again...");
                return View(model);
            }

            var service = CreateWorkService();

            if (service.UpdateWork(model))
            {
                TempData["SaveResult"] = "Congratulations!  The work attributes have been successfully updated!";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Sorry...the work attributes could not be updated");

            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var service = CreateWorkService();
            var model = service.GetWorkById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteWork(int id)
        {
            var svc = CreateWorkService();
            svc.DeleteWork(id);
            TempData["SaveResult"] = "Powerstats were successfully deleted";
            return RedirectToAction("Index");
        }

    }
}