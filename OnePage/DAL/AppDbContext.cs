using Microsoft.EntityFrameworkCore;
using OnePage.Models;

namespace OnePage.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<SosialNet> SosialNets { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Interests> Interests { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SkillsIcon> SkillsIcons { get; set; }
        public DbSet<Workflow> Workflows { get; set; }
        public DbSet<Awards> Awards { get; set; }
    }
}
