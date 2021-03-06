﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult BootstrapJsTest()
        {
            return View();
        }

        public ContentResult GetText()
        {
            System.Threading.Thread.Sleep(4000);
            return Content("This msg is from HomeController");
        }

        public ActionResult AffixTest()
        {
            return View();
        }
    }
}