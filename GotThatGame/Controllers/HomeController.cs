﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GotThatGame.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Legal()
        {
        	return View();
        }

        public ViewResult About()
        {
        	return View();
        }

        public ViewResult Support()
        {
        	return View();
        }

    }
}
