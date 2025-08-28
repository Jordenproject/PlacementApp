using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlacementApp.Models;

namespace PlacementApp.Controllers
{
    public class PlacementApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlacementApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlacementApplications
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlacementApplications.ToListAsync());
        }

        // GET: PlacementApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementApplication = await _context.PlacementApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placementApplication == null)
            {
                return NotFound();
            }

            return View(placementApplication);
        }

        // GET: PlacementApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlacementApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StudentID,StudentName,PlacementRole")] PlacementApplication placementApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placementApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(placementApplication);
        }

        // GET: PlacementApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementApplication = await _context.PlacementApplications.FindAsync(id);
            if (placementApplication == null)
            {
                return NotFound();
            }
            return View(placementApplication);
        }

        // POST: PlacementApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StudentID,StudentName,PlacementRole")] PlacementApplication placementApplication)
        {
            if (id != placementApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placementApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlacementApplicationExists(placementApplication.Id))
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
            return View(placementApplication);
        }

        // GET: PlacementApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placementApplication = await _context.PlacementApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (placementApplication == null)
            {
                return NotFound();
            }

            return View(placementApplication);
        }

        // POST: PlacementApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placementApplication = await _context.PlacementApplications.FindAsync(id);
            _context.PlacementApplications.Remove(placementApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlacementApplicationExists(int id)
        {
            return _context.PlacementApplications.Any(e => e.Id == id);
        }
    }
}
