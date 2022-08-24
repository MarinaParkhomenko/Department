using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public string FormOfControl { get; set; }
        public decimal Hours { get; set; }
        //public int CodeOfSp { get; set; }
        public int Course { get; set; }

    }
}
