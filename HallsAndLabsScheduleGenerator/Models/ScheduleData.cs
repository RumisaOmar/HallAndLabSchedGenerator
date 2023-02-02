using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShedualeGenerator.Models
{
    public class ScheduleData
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Day { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public int ScheduleId { get; set; }
        public Schedule schedule { get; set; }

    }
}
