﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroDB.WebMVC.Controllers
{
    public class BiographyController : Controller
    {
        // GET: Biography
        public ActionResult Index()
        {
            return View();
        }
    }
}