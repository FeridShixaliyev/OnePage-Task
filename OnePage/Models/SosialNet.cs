
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePage.Models
{
    public class SosialNet
    {
        public int Id { get; set; }
        public string NetImage { get; set; }
        public int AboutId { get; set; }
        public About About { get; set; }
    }
}
