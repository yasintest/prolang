﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleProject.Controllers
{
    public class SharedController : Controller
    {
        // GET: Home
        public ActionResult _Layout()
        {
            return View();
        }
    }
}