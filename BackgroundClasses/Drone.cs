using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Drone
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CoreHp { get; set; }
        public Armor[] Armors = {  };
        public int Power { get; set; }
        public int PPR { get; set; }
        public Module[] Modules = { };
        public Chassis Chassis { get; set; }
        private char[] Directions = { 'F', 'B', 'L', 'R', 'T', 'U' };
    }
}
