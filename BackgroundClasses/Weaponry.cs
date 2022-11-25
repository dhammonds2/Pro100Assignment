using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Weaponry : Module
    {
        public string WeaponType { get; set; }
        public string SpecialMechanic { get; set; }
        public string DamageDie { get; set; }
        public int minRange { get; set; }
        public int maxRange { get; set; }
        public int effectiveRange { get; set; }
    }
}
