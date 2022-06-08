using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
