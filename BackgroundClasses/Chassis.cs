using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Chassis
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] SideSlots = { 0, 0, 0, 0, 0, 0 };
        public string PermModule { get; set; }
    }
}
