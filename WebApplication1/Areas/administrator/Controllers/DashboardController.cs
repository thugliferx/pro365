﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.administrator.Controllers
{
    public class DashboardController : Controller
    {
        // GET: administrator/Dashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}