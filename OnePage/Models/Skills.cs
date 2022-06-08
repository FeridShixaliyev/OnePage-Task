using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<SkillsIcon> Icons { get; set; }
        public List<Workflow> Workflows { get; set; }

    }
}
