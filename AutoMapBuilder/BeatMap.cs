using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class BeatMap
    {

        private static string VERSION = "_version";
        private static string BPM = "_beatsPerMinute";
        private static string BEATSPERBAR = "_beatsPerBar";
        private static string NOTEJUMPSPEED = "_noteJumpSpeed";
        private static string SHUFFLE = "_shuffle";
        private static string SHUFFLEPERIOD = "_shufflePeriod";
        private static string OBSTACLES = "_obstacles";
        private static string EVENTS = "_events";

        //Events
        private static string VALUE = "_value"; //Value to pass to event

        //Notes
        private static string LINELAYER = "_lineLayer";
        private static string CUTDIRECTION = "_cutDirection";
        
        //Obstacles
        private static string DURATION = "_duration";
        private static string WIDTH = "_width";

        //Events & Obstacles
        private static string TIME = "_time"; //Time for event or obstacle
        private static string TYPE = "_type"; //Type of event or obstacle
        private static string LINE_INDEX = "_lineIndex"; //The vertical position where the note sits

        //Line Layer Height (See LINE_LAYER)
        private static int LINE_LAYER_BOTTOM = 0;
        private static int LINE_LAYER_MIDDLE = 1;
        private static int LINE_LAYER_TOP = 2;

        //Line Index (Horizontal position where the note sites)
        private static int LINE_INDEX_LEFT = 0;
        private static int LINE_INDEX_CENTER_LEFT = 1;
        private static int LINE_INDEX_CENTER_RIGHT = 2;
        private static int LINE_INDEX_RIGHT = 4;

        //Type - color of note
        private static readonly int TYPE_RED = 0;
        private static int TYPE_BLUE = 1;

        //Cut Direction
        private static int CUT_DIRECTION_UP = 0;
        private static int CUT_DIRECTION_DOWN = 1;
        private static int CUT_DIRECTION_LEFT = 2;
        private static int CUT_DIRECTION_RIGHT = 4;
        private static int CUT_DIRECTION_UP_RIGHT = 5;
        private static int CUT_DIRECTION_DOWN_LEFT = 6;
        private static int CUT_DIRECTION_DOWN_RIGHT = 7;
        private static int CUT_DIRECTION_ANY = 8;


        //Lighting Effects
        private static int LIGHTING_OFF = 0;
        private static int LIGHTING_BLUE = 1;
        private static int LIGHTING_BLUE_ALT = 2; //Unverified difference between BLUE AND BLUE_ALT
        private static int LIGHTING_RED = 5;
        private static int LIGHTING_RED_ALT = 6; //Unverified difference between RED AND RED_ALT
        private static int LIGHTING_RED_FADEOUT = 7; 
        
        private object BuildBeatMap()
        {
            return null;//construct a basic beatmap JSON array.
        }

        

        
    }
}
