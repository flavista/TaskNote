﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskNote.Models;

namespace TaskNote.Controllers
{
    public class TarjetasController : Controller
    {
        private readonly TaskNoteContext _context;

        public TarjetasController(TaskNoteContext context)
        {
            _context = context;
        }

        // GET: Tarjetas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tarjetas.ToListAsync());
        }

        // GET: Tarjetas/Details/5
        public async Task<IActionResult> Details(Guid? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas
                .FirstOrDefaultAsync(m => m.ID == ID);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // GET: Tarjetas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tarjetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,titulo,fechaInicio,fechaFin,estado,comentarios")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                tarjeta.ID = Guid.NewGuid();
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarjeta);
        }

        // GET: Tarjetas/Edit/5
        public async Task<IActionResult> Edit(Guid? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas.FindAsync(ID);
            if (tarjeta == null)
            {
                return NotFound();
            }
            return View(tarjeta);
        }

        // POST: Tarjetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,titulo,fechaInicio,fechaFin,estado,comentarios")] Tarjeta tarjeta)
        {
            if (id != tarjeta.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tarjeta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TarjetaExists(tarjeta.ID))
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
            return View(tarjeta);
        }

        // GET: Tarjetas/Delete/5
        public async Task<IActionResult> Delete(Guid? ID)
        {
            if (ID == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas
                .FirstOrDefaultAsync(m => m.ID == ID);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // POST: Tarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid ID)
        {
            var tarjeta = await _context.Tarjetas.FindAsync(ID);
            _context.Tarjetas.Remove(tarjeta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarjetaExists(Guid ID)
        {
            return _context.Tarjetas.Any(e => e.ID == ID);
        }
    }
}
