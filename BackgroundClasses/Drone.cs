using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAstroClass.BackgroundClasses
{
    public class Drone : INotifyPropertyChanged
    {
        //literally just a bunch of data please don't mess with this
        public string Name { get; set; }
        public string Description { get; set; }
        public int CoreHp { get; set; } = 5;
        public int Power { get; set; } = 100;
        public int PPR { get; set; } = 10;
        private char[] Directions = { 'F', 'B', 'L', 'R', 'T', 'U' };
        private int[] SideCount = { 0, 0, 0, 0, 0, 0 };
        public Component[] Armors { get; set; } = new Component[6]; // armor components are stored here
        public Component[] Modules { get; set; } = new Component[10]; // module components are stored here
        public Component Chassis { get; set; } // chassis is stored here. There can only be one
        public int sidesLeft { get; set; } = 10; // only kinda matters.
        public int armorLeft { get; set; } = 6; // same as above
        public bool chassisChosen { get; set; } = false; // disables modules and armors until chassis is chosen
        public int tScore { get; set; } = 0; // ignore
        public int vScore { get; set; } = 0; //ignore
        public Drone(string inName, int inCHP = 5, int inPow = 100, int inPPR = 10) //you know what this is
        {
            Name = inName;
            CoreHp = inCHP;
            Power = inPow;
            PPR = inPPR;
            Description = "";
        }

        public Drone() // default
        {

        }

        public void Remove(char type, int index) //ignore for now
        {

        }

        
        
        /// <summary>
        /// Takes in a module, then adds it to the array.
        /// </summary>
        /// <param name="inModule"></param>
        public void AddModule(Component inModule)
        {
            if (sidesLeft > 0)
            {
                for (int i = 0; i < Modules.Length; i++)
                {
                    if (Modules[i] != null)
                    {
                        Modules[i] = inModule;
                        sidesLeft--;
                        //if ()
                        //{
                        // check for specific modules
                        //}
                    }
                }
            }
            PropertyHasChanged("sidesLeft");
        }

        /// <summary>
        /// Adds a Chassis
        /// </summary>
        /// <param name="inChassis"></param>
        public void AddChassis(Component inChassis)
        {
            Chassis = inChassis;
            chassisChosen = true;
            PropertyHasChanged("chassisChosen");
        }

        /// <summary>
        /// Takes in armor to add with a direction
        /// </summary>
        /// <param name="inArmor"></param>
        public void AddArmor(Component inArmor)
        {
            if (armorLeft > 0)
            {
                for (int i = 0; i < Armors.Length; i++)
                {
                    if (Armors[i] != null)
                    {
                        Armors[i] = inArmor;
                        armorLeft--;
                    }
                }
            }
            PropertyHasChanged("ArmorLeft");
        }


        // !IMPORTANT! DO NOT MESS WITH i haven't finished certain things yet and this isn't currently used
        /// <summary>
        /// Is used to check if the chosen side slots are all filled up or not.
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        public bool CheckSidesMod(char side)
        {
            int sideCount = 0;
            for (int i = 0; i < Modules.Length; i++)
            {
                if (Modules[i].side == side)
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

        //this just updates the displayed properties, or it at least should?? idk why it doesn't sometimes
        public event PropertyChangedEventHandler? PropertyChanged;

        public void PropertyHasChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }
    }

    
}
