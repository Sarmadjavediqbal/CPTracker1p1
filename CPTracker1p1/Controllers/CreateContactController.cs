using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPTracker1p1.Controllers
{
    public class CreateContactController : Controller
    {
        // GET: CreateContactController
        public ActionResult CreateContact()
        {
            return View();
        }

        // GET: CreateContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateContactController/Create
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

        // GET: CreateContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateContactController/Edit/5
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

        // GET: CreateContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateContactController/Delete/5
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
