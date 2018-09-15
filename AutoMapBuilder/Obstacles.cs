using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class Obstacles
    {
        public double _time { get; set; }
        public int _lineIndex { get; set; }
        public int _type { get; set; }
        public int _duration { get; set; }
        public int _width { get; set; }

        public Obstacles(double timeIn, int lineIndexIn, int typeIn, int durationIn, int widthIn)
        {
            _time = timeIn;
            _lineIndex = lineIndexIn;
            _type = typeIn;
            _duration = durationIn;
            _width = widthIn;

        }

    }
}
