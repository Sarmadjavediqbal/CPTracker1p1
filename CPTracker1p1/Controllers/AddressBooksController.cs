using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CPTracker1p1.Data;
using CPTracker1p1.Models;

namespace CPTracker1p1.Controllers
{
    public class AddressBooksController : Controller
    {
        private readonly CPTracker1p1NewDbContext _context;

        public AddressBooksController(CPTracker1p1NewDbContext context)
        {
            _context = context;
        }

        // GET: AddressBooks
        public async Task<IActionResult> Index()
        {
            return View(await _context.AddressBook.ToListAsync());
        }

        // GET: AddressBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressBook = await _context.AddressBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressBook == null)
            {
                return NotFound();
            }

            return View(addressBook);
        }

        // GET: AddressBooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddressBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,EmailId,ContactNo,Company")] AddressBook addressBook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressBook = await _context.AddressBook.FindAsync(id);
            if (addressBook == null)
            {
                return NotFound();
            }
            return View(addressBook);
        }

        // POST: AddressBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,EmailId,ContactNo,Company")] AddressBook addressBook)
        {
            if (id != addressBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressBook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressBookExists(addressBook.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(addressBook);
        }

        // GET: AddressBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressBook = await _context.AddressBook
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addressBook == null)
            {
                return NotFound();
            }

            return View(addressBook);
        }

        // POST: AddressBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressBook = await _context.AddressBook.FindAsync(id);
            _context.AddressBook.Remove(addressBook);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressBookExists(int id)
        {
            return _context.AddressBook.Any(e => e.Id == id);
        }
    }
}
