using ShedualeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HallsAndLabsScheduleGenerator.ViewModel
{
    public class TeacherViewModel
    {
        public int id { get; set; }
        public Teacher Teacher { get; set; }
        public List<int> SubjectIds { get; set; }
    }
}
