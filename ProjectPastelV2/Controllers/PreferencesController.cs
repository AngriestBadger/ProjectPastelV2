using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectPastelV2.Data;
using ProjectPastelV2.Models;

namespace ProjectPastelV2.Controllers
{
    public class PreferencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreferencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Preferences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Preference.ToListAsync());
        }

        // GET: Preferences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preference = await _context.Preference
                .SingleOrDefaultAsync(m => m.PreferenceId == id);
            if (preference == null)
            {
                return NotFound();
            }

            return View(preference);
        }

        // GET: Preferences/Create
        public IActionResult Create() 
        {
            return View(); 
        }

        // POST: Preferences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PreferenceId,PreferenceDate,GroupName,Preference1,Preference2,Preference3")] Preference preference)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preference);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preference);
        }

        // GET: Preferences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preference = await _context.Preference.SingleOrDefaultAsync(m => m.PreferenceId == id);
            if (preference == null)
            {
                return NotFound();
            }
            return View(preference);
        }

        // POST: Preferences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PreferenceId,PreferenceDate,GroupName,Preference1,Preference2,Preference3")] Preference preference)
        {
            if (id != preference.PreferenceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preference);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreferenceExists(preference.PreferenceId))
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
            return View(preference);
        }

        // GET: Preferences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preference = await _context.Preference
                .SingleOrDefaultAsync(m => m.PreferenceId == id);
            if (preference == null)
            {
                return NotFound();
            }

            return View(preference);
        }

        // POST: Preferences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preference = await _context.Preference.SingleOrDefaultAsync(m => m.PreferenceId == id);
            _context.Preference.Remove(preference);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreferenceExists(int id)
        {
            return _context.Preference.Any(e => e.PreferenceId == id);
        }
    }
}
