using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShedualeGenerator.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string StudentCount { get; set; }
        public List<ScheduleData> ScheduleDatas { get; set; }
    }
}
