using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTW_rewrite_3rd.Models
{
    class Courses
    {
        public string C01_id { get; set; }
        public string C02_name { get; set; }
        public DateTime C03_datestart { get; set; }
        public DateTime C04_dateend { get; set; }

        public Courses() { }
        public Courses(string id, string name, DateTime start, DateTime end)
        {
            this.C01_id = id;
            this.C02_name = name;
            this.C03_datestart = start;
            this.C04_dateend = end;
        }
    }
}
