using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CPTracker1p1.Controllers
{
    public class CourierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Generate(string productId)
        {
            ViewBag.productId = productId;
            return View("Index");
        }
    }

}
