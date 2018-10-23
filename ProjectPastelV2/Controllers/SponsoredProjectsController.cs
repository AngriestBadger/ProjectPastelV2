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
    public class SponsoredProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SponsoredProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SponsoredProjects
        public async Task<IActionResult> Index()
        {
            return View(await _context.SponsoredProject.ToListAsync());
        }

        // GET: SponsoredProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsoredProject = await _context.SponsoredProject
                .SingleOrDefaultAsync(m => m.SponsoredProjectId == id);
            if (sponsoredProject == null)
            {
                return NotFound();
            }

            return View(sponsoredProject);
        }

        // GET: SponsoredProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SponsoredProjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SponsoredProjectId,ProjectDate,SponsorName,Title,Description,Contacts,InScope,OutOfScope,SkillRequirements,RelatedProjects,TeamSize,Duration,IsAllocated")] SponsoredProject sponsoredProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sponsoredProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sponsoredProject);
        }

        // GET: SponsoredProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsoredProject = await _context.SponsoredProject.SingleOrDefaultAsync(m => m.SponsoredProjectId == id);
            if (sponsoredProject == null)
            {
                return NotFound();
            }
            return View(sponsoredProject);
        }

        // POST: SponsoredProjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SponsoredProjectId,ProjectDate,SponsorName,Title,Description,Contacts,InScope,OutOfScope,SkillRequirements,RelatedProjects,TeamSize,Duration,IsAllocated")] SponsoredProject sponsoredProject)
        {
            if (id != sponsoredProject.SponsoredProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sponsoredProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SponsoredProjectExists(sponsoredProject.SponsoredProjectId))
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
            return View(sponsoredProject);
        }

        // GET: SponsoredProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsoredProject = await _context.SponsoredProject
                .SingleOrDefaultAsync(m => m.SponsoredProjectId == id);
            if (sponsoredProject == null)
            {
                return NotFound();
            }

            return View(sponsoredProject);
        }

        // POST: SponsoredProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sponsoredProject = await _context.SponsoredProject.SingleOrDefaultAsync(m => m.SponsoredProjectId == id);
            _context.SponsoredProject.Remove(sponsoredProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SponsoredProjectExists(int id)
        {
            return _context.SponsoredProject.Any(e => e.SponsoredProjectId == id);
        }
    }
}
