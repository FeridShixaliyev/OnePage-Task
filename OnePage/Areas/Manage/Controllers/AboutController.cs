using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnePage.DAL;
using OnePage.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class AboutController : Controller
    {
        private readonly AppDbContext _sql;

        public AboutController(AppDbContext sql)
        {
            _sql = sql;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: AboutController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }
        public IActionResult Edit(int? id)
        {
            About about = _sql.Abouts.FirstOrDefault(a=>a.Id==id);
            if (about == null) return NotFound();
            return View(about);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(About about)
        {
            if (!ModelState.IsValid) return View();
            About editAbout = _sql.Abouts.FirstOrDefault(a => a.Id == about.Id);
            if (editAbout == null) return NotFound();
            editAbout.Title = about.Title;
            editAbout.Text = about.Text;
            editAbout.Address = about.Address;
            editAbout.Email = about.Email;
            editAbout.PhoneNumber = about.PhoneNumber;
            await _sql.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: AboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
