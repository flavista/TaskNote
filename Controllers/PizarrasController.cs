using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskNote.Models;

namespace TaskNote.Controllers
{
    public class PizarrasController : Controller
    {
        private readonly TaskNoteDbContext _context;

        public PizarrasController(TaskNoteDbContext context)
        {
            _context = context;
        }

        // GET: Pizarras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizarras.ToListAsync());
        }

        // GET: Pizarras/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizarra = await _context.Pizarras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizarra == null)
            {
                return NotFound();
            }

            return View(pizarra);
        }

        // GET: Pizarras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pizarras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Pizarra pizarra)
        {
            if (ModelState.IsValid)
            {
                pizarra.Id = Guid.NewGuid();
                _context.Add(pizarra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pizarra);
        }

        // GET: Pizarras/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizarra = await _context.Pizarras.FindAsync(id);
            if (pizarra == null)
            {
                return NotFound();
            }
            return View(pizarra);
        }

        // POST: Pizarras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nombre")] Pizarra pizarra)
        {
            if (id != pizarra.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizarra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizarraExists(pizarra.Id))
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
            return View(pizarra);
        }

        // GET: Pizarras/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizarra = await _context.Pizarras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pizarra == null)
            {
                return NotFound();
            }

            return View(pizarra);
        }

        // POST: Pizarras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pizarra = await _context.Pizarras.FindAsync(id);
            _context.Pizarras.Remove(pizarra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizarraExists(Guid id)
        {
            return _context.Pizarras.Any(e => e.Id == id);
        }
    }
}
