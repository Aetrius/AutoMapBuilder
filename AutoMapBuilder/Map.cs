using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    public class Map
    {
        public string _version { get; set; }
        public int _beatsPerMinute { get; set; }
        public int _beatPerBar { get; set; }
        public int _noteJumpSpeed { get; set; }
        public int _shuffle { get; set; }
        public double _shufflePeriod { get; set; }
        public object _events { get; set; }
        public object _notes { get; set; }
        public object _obstacles { get; set; }



    }
}
