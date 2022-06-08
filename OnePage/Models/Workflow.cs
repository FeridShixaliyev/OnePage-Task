using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Models
{
    public class Workflow
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SkillsId { get; set; }
        public Skills Skills { get; set; }
    }
}
