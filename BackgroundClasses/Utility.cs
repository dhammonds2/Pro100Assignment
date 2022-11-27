using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Utility : Module
    {
        public Utility(string mechanic, string skill, string otherEffect, string name, int index, string description, int powerCost, int moneyCost, char direction) : base(name, index, description, powerCost, moneyCost, direction)
        {
            Name = name;
            Index = index;
            Description = description;
            PowerCost = powerCost;
            MoneyCost = moneyCost;
            Direction = direction;
            Mechanic = mechanic;
            Skill = skill;
            OtherEffect = otherEffect;

        }

        public string Mechanic { get; set; }
        public string Skill { get; set; }
        public string OtherEffect { get; set; }
    }
}
