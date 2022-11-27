using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Module
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string Description { get; set; }
        public int PowerCost { get; set; }
        public int MoneyCost { get; set; }
        public char Direction { get; set; }

        public Module(string name, int index, string description, int powerCost, int moneyCost, char direction)
        {
            Name = name;
            Index = index;
            Description = description;
            PowerCost = powerCost;
            MoneyCost = moneyCost;
            Direction = direction;
        }
    }
}
