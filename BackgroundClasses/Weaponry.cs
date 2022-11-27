using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Weaponry : Module
    {
        public Weaponry(string weaponType, string specialMechanic, string damageDie, int iMinRange, int iMaxRange, int iEffectiveRange, string name, int index, string description, int powerCost, int moneyCost, char direction) : base(name, index, description, powerCost, moneyCost, direction)
        {
            Name = name;
            Index = index;
            Description = description;
            PowerCost = powerCost;
            MoneyCost = moneyCost;
            Direction = direction;
            WeaponType = weaponType;
            SpecialMechanic = specialMechanic;
            DamageDie = damageDie;
            minRange = iMinRange;
            maxRange = iMaxRange;
            effectiveRange = iEffectiveRange;
        }

        public string WeaponType { get; set; }
        public string SpecialMechanic { get; set; }
        public string DamageDie { get; set; }
        public int minRange { get; set; }
        public int maxRange { get; set; }
        public int effectiveRange { get; set; }
    }
}
