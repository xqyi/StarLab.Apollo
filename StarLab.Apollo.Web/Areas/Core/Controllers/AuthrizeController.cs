﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StarLab.Apollo.Web.Areas.Core.Controllers
{
    public class AuthrizeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}