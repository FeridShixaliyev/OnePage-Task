using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.ViewModels
{
    public class ModelsVM
    {
        public List<About> About { get; set; }
        public List<SosialNet> SosialNets { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Interests> Interests { get; set; }
        public List<Skills> Skills { get; set; }
        public List<SkillsIcon> SkillsIcons { get; set; }
        public List<Workflow> Workflows { get; set; }
        public List<Awards > Awards { get; set; }
    }
}
