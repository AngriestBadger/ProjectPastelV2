using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectPastelV2.Data;
using ProjectPastelV2.Models;

namespace ProjectPastelV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context; 
        }

        public async Task<IActionResult> SelectProject() 
        {
            ViewData["Message"] = "Project Selection page.";

            var allProjects = from sponsoredProject in _context.SponsoredProject
                              orderby sponsoredProject.ProjectDate descending
                              select sponsoredProject;
            return View(allProjects.ToListAsync()); 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
