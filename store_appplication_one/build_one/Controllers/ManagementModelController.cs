using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using build_one.Models;

namespace build_one.Controllers
{
    public class ManagementModelController : Controller
    {
        private readonly store_dataContext _context;

        public ManagementModelController(store_dataContext context)
        {
            _context = context;
        }

        // GET: ManagementModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ManagementModel.ToListAsync());
        }

        // GET: ManagementModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managementModel = await _context.ManagementModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managementModel == null)
            {
                return NotFound();
            }

            return View(managementModel);
        }

        // GET: ManagementModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ManagementModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Department,Location")] ManagementModel managementModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(managementModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(managementModel);
        }

        // GET: ManagementModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managementModel = await _context.ManagementModel.FindAsync(id);
            if (managementModel == null)
            {
                return NotFound();
            }
            return View(managementModel);
        }

        // POST: ManagementModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Department,Location")] ManagementModel managementModel)
        {
            if (id != managementModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(managementModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagementModelExists(managementModel.Id))
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
            return View(managementModel);
        }

        // GET: ManagementModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managementModel = await _context.ManagementModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managementModel == null)
            {
                return NotFound();
            }

            return View(managementModel);
        }

        // POST: ManagementModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var managementModel = await _context.ManagementModel.FindAsync(id);
            _context.ManagementModel.Remove(managementModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagementModelExists(int id)
        {
            return _context.ManagementModel.Any(e => e.Id == id);
        }
    }
}
