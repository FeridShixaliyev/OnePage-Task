using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnePage.DAL;
using OnePage.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _sql;

        public HomeController(AppDbContext sql)
        {
            _sql = sql;
        }

        public async Task<IActionResult> Index()
        {
            ModelsVM modelsVM = new ModelsVM
            {
                About = await _sql.Abouts.ToListAsync(),
                Awards = await _sql.Awards.ToListAsync(),
                Educations = await _sql.Educations.ToListAsync(),
                Experiences=await _sql.Experiences.ToListAsync(),
                Interests=await _sql.Interests.ToListAsync(),
                Skills=await _sql.Skills.ToListAsync(),
                SkillsIcons=await _sql.SkillsIcons.ToListAsync(),
                SosialNets=await _sql.SosialNets.ToListAsync(),
                Workflows=await _sql.Workflows.ToListAsync(),
            };
            return View(modelsVM);
        }
    }
}
