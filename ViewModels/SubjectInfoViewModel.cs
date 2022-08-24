using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;

namespace Department.ViewModels
{
    public class SubjectInfoViewModel
    {
        public Subject Subject { get; set; }
        public Teacher Teacher { get; set; }
        public Specialty Specialty { get; set; }

    }
}
