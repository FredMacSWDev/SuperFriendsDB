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
            var model = new AppearanceListItem[0];
            return View();
        }
    }
}