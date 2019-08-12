using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visit_control.Models
{
    public class Visitors_Department
    {
        public int id { get; set; }
        public string department { get; set; }
        public string reason { get; set; }
        public string observation { get; set; }
        public DateTime entry { get; set; }
        public int id_visitor { get; set; }
    }
}
