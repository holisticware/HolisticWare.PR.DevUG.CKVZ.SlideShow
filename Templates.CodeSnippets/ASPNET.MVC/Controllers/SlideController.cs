﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolisticWare.SlideShow.EXE.Controllers
{
    public class SlideController : Controller
    {
        //
        // GET: /Slide/

        public ActionResult Index()
        {
            return View(new HolisticWare.SlideShow.EXE.Models.Slides());
        }

    }
}
