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
        public int Index { get; set; }
        public string Description { get; set; }
        public int MoneyCost { get; set; }
        public int ArmorHP { get; set; }
        public int DamageThreshold { get; set; }
        public char Direction { get; set; }

        public Armor(string name, int index, string description, int moneyCost, int armorHP, int damageThreshold)
        {
            Name = name;
            Index = index;
            Description = description;
            MoneyCost = moneyCost;
            ArmorHP = armorHP;
            DamageThreshold = damageThreshold;
            Direction = ' ';
        }
    }
}
