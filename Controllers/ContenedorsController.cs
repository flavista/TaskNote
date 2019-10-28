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
    public class ContenedorsController : Controller
    {
        private readonly TaskNoteContext _context;

        public ContenedorsController(TaskNoteContext context)
        {
            _context = context;
        }

        // GET: Contenedors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contenedors.ToListAsync());
        }

        // GET: Contenedors/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contenedor == null)
            {
                return NotFound();
            }

            return View(contenedor);
        }

        // GET: Contenedors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contenedors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,nombre")] Contenedor contenedor)
        {
            if (ModelState.IsValid)
            {
                contenedor.ID = Guid.NewGuid();
                _context.Add(contenedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contenedor);
        }

        // GET: Contenedors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedors.FindAsync(id);
            if (contenedor == null)
            {
                return NotFound();
            }
            return View(contenedor);
        }

        // POST: Contenedors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,nombre")] Contenedor contenedor)
        {
            if (id != contenedor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contenedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContenedorExists(contenedor.ID))
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
            return View(contenedor);
        }

        // GET: Contenedors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedors
                .FirstOrDefaultAsync(m => m.ID == id);
            if (contenedor == null)
            {
                return NotFound();
            }

            return View(contenedor);
        }

        // POST: Contenedors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contenedor = await _context.Contenedors.FindAsync(id);
            _context.Contenedors.Remove(contenedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContenedorExists(Guid id)
        {
            return _context.Contenedors.Any(e => e.ID == id);
        }
    }
}
