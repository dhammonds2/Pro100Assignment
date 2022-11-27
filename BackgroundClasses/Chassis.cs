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
        public int Index { get; set; }
        public string Description { get; set; }
        public int[] SideSlots = { 0, 0, 0, 0, 0, 0 };
        public string PermModule { get; set; }

        public Chassis(string inName, int inIndex, string inDescription, int[] inSS, string inModule)
        {
            Name = inName;
            Index = inIndex;
            Description = inDescription;
            SideSlots = inSS;
            PermModule = inModule;
        }
    }
}
