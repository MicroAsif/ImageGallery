﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImageGalley.Web.Areas.Admin.Controllers
{
    public class ImageManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}