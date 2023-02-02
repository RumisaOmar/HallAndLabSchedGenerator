using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShedualeGenerator.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public List<ScheduleData> scheduleDatas { get; set; }
        public List<Teacher_Subject> teacher_Subjects { get; set; }

    }
}
