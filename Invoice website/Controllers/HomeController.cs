﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invoice_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Jeff Hamlin";

            return View();
        }
        public ActionResult InvoiceData()
        {
            ViewBag.Title = "Jeff Hamlin";

            return View();
        }
    }
}
