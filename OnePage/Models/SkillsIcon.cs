using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Models
{
    public class SkillsIcon
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }
    }
}
