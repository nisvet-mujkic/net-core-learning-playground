using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomAttributePractice.Data;
using CustomAttributePractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomAttributePractice.Controllers
{
    public class ProjectController : Controller
    {
        private readonly NetContext db;

        public ProjectController(NetContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Project.ToList());
        }

        public IActionResult Dodaj()
        {
            return View(new Project());
        }

        [HttpPost]
        public IActionResult Dodaj(Project project)
        {
            db.Project.Add(project);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public void GenerateNextNumber()
        {
            Project project = db.Project.Last();


        }
    }
}