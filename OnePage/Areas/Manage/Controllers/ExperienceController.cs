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
    public class ExperienceController : Controller
    {
        private readonly AppDbContext _sql;

        public ExperienceController(AppDbContext sql)
        {
            _sql = sql;
        }
        public async Task<IActionResult> Index()
        {
            List<Experience> experiences = await _sql.Experiences.ToListAsync();
            return View(experiences);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Experience experience)
        {
            if (!ModelState.IsValid) return View();
            if (experience == null) return NotFound();
            await _sql.Experiences.AddAsync(experience);
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        //public IActionResult Edit(int? id)
        //{
        //    Experience experience = _sql.Experiences.Find(id);
        //    return View(experience);
        //}
        public IActionResult Edit(int id)
        {
            Experience experience = _sql.Experiences.Find(id);
            return View(experience);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Experience experience)
        {
            if (!ModelState.IsValid) return View();
            Experience experience1 = _sql.Experiences.FirstOrDefault(e=>e.Id==id);
            if (experience1 == null) return NotFound();
            experience1.Title = experience.Title;
            experience1.Subtitle = experience.Subtitle;
            experience1.Text = experience.Text;
            experience1.Date = experience.Date;
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            Experience experience=_sql.Experiences.Find(id);
            _sql.Experiences.Remove(experience);
            _sql.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
