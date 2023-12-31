﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Trabajofinal2.Data;
using Trabajofinal2.Models;

namespace Trabajofinal2.Controllers
{
    public class EscuelasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EscuelasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Escuelas
        public async Task<IActionResult> Index()
        {
              return _context.Escuelas != null ? 
                          View(await _context.Escuelas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Escuelas'  is null.");
        }

        // GET: Escuelas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Escuelas == null)
            {
                return NotFound();
            }

            var escuela = await _context.Escuelas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (escuela == null)
            {
                return NotFound();
            }

            return View(escuela);
        }

        // GET: Escuelas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Escuelas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Cantidadalumnos")] Escuela escuela)
        {
            if (ModelState.IsValid)
            {
                _context.Add(escuela);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(escuela);
        }

        // GET: Escuelas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Escuelas == null)
            {
                return NotFound();
            }

            var escuela = await _context.Escuelas.FindAsync(id);
            if (escuela == null)
            {
                return NotFound();
            }
            return View(escuela);
        }

        // POST: Escuelas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Cantidadalumnos")] Escuela escuela)
        {
            if (id != escuela.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(escuela);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EscuelaExists(escuela.Id))
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
            return View(escuela);
        }

        // GET: Escuelas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Escuelas == null)
            {
                return NotFound();
            }

            var escuela = await _context.Escuelas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (escuela == null)
            {
                return NotFound();
            }

            return View(escuela);
        }

        // POST: Escuelas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Escuelas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Escuelas'  is null.");
            }
            var escuela = await _context.Escuelas.FindAsync(id);
            if (escuela != null)
            {
                _context.Escuelas.Remove(escuela);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EscuelaExists(int id)
        {
          return (_context.Escuelas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
