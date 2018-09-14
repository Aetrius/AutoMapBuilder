using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class Events
    {

        public double _time { get; set; }
        public int _type { get; set; }
        public int _value { get; set; }

        public Events(double timeIn, int typeIn, int valueIn)
        {

            _time = timeIn;
            _type = typeIn;
            _value = valueIn;

        }

    }
}
