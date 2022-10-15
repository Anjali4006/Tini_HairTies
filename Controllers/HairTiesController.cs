using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tini_HairTies.Data;
using Tini_HairTies.Models;

namespace Tini_HairTies.Controllers
{
    public class HairTiesController : Controller
    {
        private readonly HairTiesContext _context;

        public HairTiesController(HairTiesContext context)
        {
            _context = context;
        }

        // GET: HairTies
        public async Task<IActionResult> Index()
        {
            return View(await _context.HairTie.ToListAsync());
        }

        // GET: HairTies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hairTies = await _context.HairTie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hairTies == null)
            {
                return NotFound();
            }

            return View(hairTies);
        }

        // GET: HairTies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HairTies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Material,Type,Colour,Company,Quantity,Price")] HairTies hairTies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hairTies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hairTies);
        }

        // GET: HairTies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hairTies = await _context.HairTie.FindAsync(id);
            if (hairTies == null)
            {
                return NotFound();
            }
            return View(hairTies);
        }

        // POST: HairTies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Material,Type,Colour,Company,Quantity,Price")] HairTies hairTies)
        {
            if (id != hairTies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hairTies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HairTiesExists(hairTies.Id))
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
            return View(hairTies);
        }

        // GET: HairTies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hairTies = await _context.HairTie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hairTies == null)
            {
                return NotFound();
            }

            return View(hairTies);
        }

        // POST: HairTies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hairTies = await _context.HairTie.FindAsync(id);
            _context.HairTie.Remove(hairTies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HairTiesExists(int id)
        {
            return _context.HairTie.Any(e => e.Id == id);
        }
    }
}
