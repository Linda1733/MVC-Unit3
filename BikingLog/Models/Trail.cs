using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikingLog.Models
{
    public class Trail
    {
        public int TrailID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Miles { get; set; }
        public int DifficultyLevel { get; set; }
    }
}
