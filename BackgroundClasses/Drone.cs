using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    internal class Drone : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CoreHp { get; set; } = 5;
        public Armor[] Armors = {  };
        public int Power { get; set; } = 100;
        public int PPR { get; set; } = 10;
        public Module[] Modules = { };
        public Chassis Chassis { get; set; }
        private char[] Directions = { 'F', 'B', 'L', 'R', 'T', 'U' };

        public Drone(string inName, int inCHP = 5, int inPow = 100, int inPPR = 10)
        {
            Name = inName;
            CoreHp = inCHP;
            Power = inPow;
            PPR = inPPR;
            Description = "";
        }

        public Drone()
        {

        }
        
        /// <summary>
        /// Takes in a module, then adds it to the array.
        /// </summary>
        /// <param name="inModule"></param>
        void AddModule(Module inModule)
        {
            for(int i = 0; i < Modules.Length; i++)
            {
                if (Modules[i] != null)
                {
                    Modules[i] = inModule;

                    //if ()
                    //{
                        // check for specific modules
                    //}
                }
            }
        }

        /// <summary>
        /// Adds a Chassis
        /// </summary>
        /// <param name="inChassis"></param>
        void AddChassis(Chassis inChassis)
        {
            Chassis = inChassis;
        }

        /// <summary>
        /// Takes in armor to add with a direction
        /// </summary>
        /// <param name="inArmor"></param>
        void AddArmor(Armor inArmor)
        {
            for (int i = 0; i < Armors.Length; i++)
            {
                if (Armors[i] != null)
                {
                    Armors[i] = inArmor;
                }
            }
        }

        /// <summary>
        /// Is used to check if the chosen side slots are all filled up or not.
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        bool CheckSidesMod(char side)
        {
            int sideCount = 0;
            for (int i = 0; i < Modules.Length; i++)
            {
                if (Modules[i].Direction == side)
                {
                    sideCount++;
                }
            }
            int sideIndex = 0;
            for(int i = 0; i < Directions.Length; i++)
            {
                if (side == Directions[i])
                {
                    sideIndex = i;
                }
            }

            if(sideCount == Directions[sideIndex])
            {
                return false;
            }
            return true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void PropertyHasChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }
    }

    
}
