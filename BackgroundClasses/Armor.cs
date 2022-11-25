using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Armor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MoneyCost { get; set; }
        public int ArmorHP { get; set; }
        public int DamageThreshold { get; set; }
        public char Direction { get; set; }
    }
}
