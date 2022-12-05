using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Mobility : Module
    {
        //public Mobility(int tScore, int vScore, string name, int index, string description, int powerCost, int moneyCost, char direction) : base(name, index, description, powerCost, moneyCost, direction)
        //{
        //    Name = name;
        //    Index = index;
        //    Description = description;
        //    PowerCost = powerCost;
        //    MoneyCost = moneyCost;
        //    Direction = direction;
        //    TScore = tScore;
        //    VScore = vScore;
        //}

        public int TScore { get; set; }
        public int VScore { get; set; }
    }
}
