using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    public class Component
    {
        public int index { get; set; } // Chassis: (0) ... // Armor: (1) // Modules: (101)U, (102)M, (103)W
        public int indexD { get; set; } // Gives the specific placement of correlating display object from the array droneControls.
        public char side { get; set; } // the side currently doesn't matter. Will later once I work more on this on my own time.

        public Component(int index, int indexD, char side)
        {
            this.index = index;
            this.indexD = indexD;
            this.side = side;
        }
    }
}
