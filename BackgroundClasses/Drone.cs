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

        public event PropertyChangedEventHandler? PropertyChanged;



        private void PropertyHasChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }
    }

    
}
