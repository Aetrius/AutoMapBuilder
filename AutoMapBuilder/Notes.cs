﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class Notes
    {
        public double _time { get; set; }
        public int _lineIndex { get; set; }
        public int _lineLayer { get; set; }
        public int _type { get; set; }
        public int _cutDirection { get; set; }

        public Notes(double timeIn, int lineIndexIn, int lineLayerIn, int typeIn, int cutDirectionIn)
        {
            _time = timeIn;
            _lineIndex = lineIndexIn;
            _lineLayer = lineLayerIn;
            _type = typeIn;
            _cutDirection = cutDirectionIn;
        }
    }
}
