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
    public class ContenedoresController : Controller
    {
        private readonly TaskNoteDbContext _context;

        public ContenedoresController(TaskNoteDbContext context)
        {
            _context = context;
        }

        // GET: Contenedores
        public async Task<IActionResult> Index()
        {
            var taskNoteDbContext = _context.Contenedores.Include(c => c.Pizarra);
            return View(await taskNoteDbContext.ToListAsync());
        }

        // GET: Contenedores/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedores
                .Include(c => c.Pizarra)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contenedor == null)
            {
                return NotFound();
            }

            return View(contenedor);
        }

        // GET: Contenedores/Create
        public IActionResult Create()
        {
            ViewData["PizarraId"] = new SelectList(_context.Pizarras, "Id", "Id");
            return View();
        }

        // POST: Contenedores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,PizarraId")] Contenedor contenedor)
        {
            if (ModelState.IsValid)
            {
                contenedor.Id = Guid.NewGuid();
                _context.Add(contenedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PizarraId"] = new SelectList(_context.Pizarras, "Id", "Id", contenedor.PizarraId);
            return View(contenedor);
        }

        // GET: Contenedores/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedores.FindAsync(id);
            if (contenedor == null)
            {
                return NotFound();
            }
            ViewData["PizarraId"] = new SelectList(_context.Pizarras, "Id", "Id", contenedor.PizarraId);
            return View(contenedor);
        }

        // POST: Contenedores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nombre,PizarraId")] Contenedor contenedor)
        {
            if (id != contenedor.Id)
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
                    if (!ContenedorExists(contenedor.Id))
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
            ViewData["PizarraId"] = new SelectList(_context.Pizarras, "Id", "Id", contenedor.PizarraId);
            return View(contenedor);
        }

        // GET: Contenedores/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contenedor = await _context.Contenedores
                .Include(c => c.Pizarra)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contenedor == null)
            {
                return NotFound();
            }

            return View(contenedor);
        }

        // POST: Contenedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var contenedor = await _context.Contenedores.FindAsync(id);
            _context.Contenedores.Remove(contenedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContenedorExists(Guid id)
        {
            return _context.Contenedores.Any(e => e.Id == id);
        }
    }
}
