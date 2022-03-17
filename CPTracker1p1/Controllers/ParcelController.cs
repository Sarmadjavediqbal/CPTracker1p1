using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPTracker1p1.Controllers
{
    [Authorize]
    public class ParcelController : Controller
    {
        // GET: ParcelController
        public ActionResult SentItem()
        {
            return View();
        }

        public ActionResult SendNewPar()
        {
            return View();
        }

        public ActionResult ReceiveItem()
        {
            return View();
        }

        public ActionResult ReceiveNewPar()
        {
            return View();
        }

        // GET: ParcelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ParcelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParcelController/Create
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

        // GET: ParcelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParcelController/Edit/5
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

        // GET: ParcelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParcelController/Delete/5
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
