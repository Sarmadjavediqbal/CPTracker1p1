using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace CPTracker1p1.Controllers
{
    [Authorize]
    public class AddressBookController : Controller
    {
        
        // GET: AddressBookController
        public ActionResult Contact()
        {
            return View();
        }

        //GET: CreateContactForm/Create
        public IActionResult CreateContactForm()
        {
            return View();
        }


        // GET: AddressBookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddressBookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AddressBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressBookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddressBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddressBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddressBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
