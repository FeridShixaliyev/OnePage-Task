using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnePage.DAL;
using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SkillsController : Controller
    {
        private readonly AppDbContext _sql;

        public SkillsController(AppDbContext sql)
        {
            _sql = sql;
        }
        public async Task<IActionResult> Index()
        {
            List<Skills> skills = await _sql.Skills.Include(s => s.Icons).Include(s => s.Workflows).ToListAsync();
            return View(skills);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Skills skills)
        {
            if (!ModelState.IsValid) return View();
            if (skills == null) return NotFound();
            foreach (var item in skills.Icons)
            {
                skills.Icons.Add(item);
            }
            foreach (var item in skills.Workflows)
            {
                skills.Workflows.Add(item);
            }
            await _sql.Skills.AddAsync(skills);
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Skills skills = _sql.Skills.Find(id);
            _sql.Skills.Remove(skills);
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
