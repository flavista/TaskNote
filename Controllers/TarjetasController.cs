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
    public class TarjetasController : Controller
    {
        private readonly TaskNoteDbContext _context;

        public TarjetasController(TaskNoteDbContext context)
        {
            _context = context;
        }

        // GET: Tarjetas
        public async Task<IActionResult> Index()
        {
            var taskNoteDbContext = _context.Tarjetas.Include(t => t.Contenedor);
            return View(await taskNoteDbContext.ToListAsync());
        }

        // GET: Tarjetas/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas
                .Include(t => t.Contenedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // GET: Tarjetas/Create
        public IActionResult Create()
        {
            ViewData["ContenedorId"] = new SelectList(_context.Contenedores, "Id", "Id");
            return View();
        }

        // POST: Tarjetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,FechaInicio,FechaFin,Descripcion,ContenedorId")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                tarjeta.Id = Guid.NewGuid();
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContenedorId"] = new SelectList(_context.Contenedores, "Id", "Id", tarjeta.ContenedorId);
            return View(tarjeta);
        }

        // GET: Tarjetas/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas.FindAsync(id);
            if (tarjeta == null)
            {
                return NotFound();
            }
            ViewData["ContenedorId"] = new SelectList(_context.Contenedores, "Id", "Id", tarjeta.ContenedorId);
            return View(tarjeta);
        }

        // POST: Tarjetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Titulo,FechaInicio,FechaFin,Descripcion,ContenedorId")] Tarjeta tarjeta)
        {
            if (id != tarjeta.Id)
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
                    if (!TarjetaExists(tarjeta.Id))
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
            ViewData["ContenedorId"] = new SelectList(_context.Contenedores, "Id", "Id", tarjeta.ContenedorId);
            return View(tarjeta);
        }

        // GET: Tarjetas/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarjeta = await _context.Tarjetas
                .Include(t => t.Contenedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tarjeta == null)
            {
                return NotFound();
            }

            return View(tarjeta);
        }

        // POST: Tarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tarjeta = await _context.Tarjetas.FindAsync(id);
            _context.Tarjetas.Remove(tarjeta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TarjetaExists(Guid id)
        {
            return _context.Tarjetas.Any(e => e.Id == id);
        }
    }
}
