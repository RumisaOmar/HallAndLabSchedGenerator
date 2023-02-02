using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShedualeGenerator.Models
{
    public class Lab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int StudentCount { get; set; }
        public string Board { get; set; }
        public string Projector { get; set; }
    }
}
