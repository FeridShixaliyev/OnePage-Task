using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnePage.DAL;
using OnePage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class EducationController : Controller
    {
        private readonly AppDbContext _sql;

        public EducationController(AppDbContext sql)
        {
            _sql = sql;
        }
        public async Task<IActionResult> Index()
        {
            List<Education> educations =await _sql.Educations.ToListAsync();
            return View(educations);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Education education)
        {
            if (ModelState.IsValid) return View();
            if (education == null) return NotFound();
            await _sql.Educations.AddAsync(education);
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            Education education = await _sql.Educations.FindAsync(id);
            return View(education);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Education education)
        {
            if (!ModelState.IsValid) return View();
            Education education1 = await _sql.Educations.FirstOrDefaultAsync(e=>e.Id==id);
            if (education1 == null) return NotFound();
            education1.Title = education.Title;
            education1.Subtitle = education.Subtitle;
            education1.Content = education.Content;
            education1.Date = education.Date;
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            Education education = await _sql.Educations.FindAsync(id);
             _sql.Educations.Remove(education);
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
