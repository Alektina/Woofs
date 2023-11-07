﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Woof;
using Woof.Models;

namespace Woof.Controllers
{
    public class KennelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KennelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kennels
        public async Task<IActionResult> Index()
        {
              return _context.Kennels != null ? 
                          View(await _context.Kennels.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Kennels'  is null.");
        }

        // GET: Kennels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Kennels == null)
            {
                return NotFound();
            }

            var kennel = await _context.Kennels
                .FirstOrDefaultAsync(m => m.KennelID == id);
            if (kennel == null)
            {
                return NotFound();
            }

            return View(kennel);
        }

        // GET: Kennels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kennels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KennelID,KennelName,Description")] Kennel kennel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kennel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kennel);
        }

        // GET: Kennels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Kennels == null)
            {
                return NotFound();
            }

            var kennel = await _context.Kennels.FindAsync(id);
            if (kennel == null)
            {
                return NotFound();
            }
            return View(kennel);
        }

        // POST: Kennels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KennelID,KennelName,Description")] Kennel kennel)
        {
            if (id != kennel.KennelID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kennel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KennelExists(kennel.KennelID))
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
            return View(kennel);
        }

        // GET: Kennels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Kennels == null)
            {
                return NotFound();
            }

            var kennel = await _context.Kennels
                .FirstOrDefaultAsync(m => m.KennelID == id);
            if (kennel == null)
            {
                return NotFound();
            }

            return View(kennel);
        }

        // POST: Kennels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Kennels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Kennels'  is null.");
            }
            var kennel = await _context.Kennels.FindAsync(id);
            if (kennel != null)
            {
                _context.Kennels.Remove(kennel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KennelExists(int id)
        {
          return (_context.Kennels?.Any(e => e.KennelID == id)).GetValueOrDefault();
        }
    }
}
