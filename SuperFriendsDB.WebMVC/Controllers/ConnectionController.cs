using SuperFriendsDB.Models.ConnectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperFriendsDB.WebMVC.Controllers
{
    [Authorize]
    public class ConnectionController : Controller
    {
        // GET: Connection
        public ActionResult Index()
        {
            var model = new ConnectionListItem[0];
            return View(model);
        }
    }
}