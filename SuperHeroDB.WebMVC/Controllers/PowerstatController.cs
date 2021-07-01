using SuperFriendsDB.Models.PowerstatModels;
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
            var model = new PowerstatListItem[0];
            return View(model);
        }
    }
}