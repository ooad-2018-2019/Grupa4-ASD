﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HospitalisOOAD.Models;

namespace HospitalisOOAD.Controllers
{
    public class IzvjestajsController : Controller
    {
        private readonly HospitalisContext _context;

        public IzvjestajsController(HospitalisContext context)
        {
            _context = context;
        }

        // GET: Izvjestajs
        public async Task<IActionResult> Index()
        {
            return View(await _context.izvjestaji.ToListAsync());
        }

        // GET: Izvjestajs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.izvjestaji
                .FirstOrDefaultAsync(m => m.IzvjestajId == id);
            if (izvjestaj == null)
            {
                return NotFound();
            }

            return View(izvjestaj);
        }

        // GET: Izvjestajs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Izvjestajs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IzvjestajId,rezultatPregleda,DokumentacijaId")] Izvjestaj izvjestaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(izvjestaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(izvjestaj);
        }

        // GET: Izvjestajs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.izvjestaji.FindAsync(id);
            if (izvjestaj == null)
            {
                return NotFound();
            }
            return View(izvjestaj);
        }

        // POST: Izvjestajs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IzvjestajId,rezultatPregleda,DokumentacijaId")] Izvjestaj izvjestaj)
        {
            if (id != izvjestaj.IzvjestajId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(izvjestaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IzvjestajExists(izvjestaj.IzvjestajId))
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
            return View(izvjestaj);
        }

        // GET: Izvjestajs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.izvjestaji
                .FirstOrDefaultAsync(m => m.IzvjestajId == id);
            if (izvjestaj == null)
            {
                return NotFound();
            }

            return View(izvjestaj);
        }

        // POST: Izvjestajs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var izvjestaj = await _context.izvjestaji.FindAsync(id);
            _context.izvjestaji.Remove(izvjestaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IzvjestajExists(int id)
        {
            return _context.izvjestaji.Any(e => e.IzvjestajId == id);
        }
    }
}
