using Microsoft.AspNet.Identity;
using SuperFriendsDB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    public class SuperFriendsController : Controller
    {
        // GET: SuperFriends
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SuperFriendsService(userId);
            var model = service.GetSuperfriends();

            return View(model);
        }

        public ActionResult GetSuperfriends()
        {
            SuperFriendsService superFriendsService = CreateSuperfriendsService();
            var superfriends = superFriendsService.GetSuperfriends();
            return View();
        }

        public ActionResult GetSuperfriendsById(int id)
        {
            SuperFriendsService superFriendsService = CreateSuperfriendsService();
            var superfriend = superFriendsService.GetSuperfriendsById(id);
            return View();
        }

        public ActionResult Details(int id)
        {
            var service = CreateSuperfriendsService();
            var model = service.GetSuperfriendsById(id);

            return View(model);
        }

        private SuperFriendsService CreateSuperfriendsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new SuperFriendsService(userId);
            return service;
        }
    }
}