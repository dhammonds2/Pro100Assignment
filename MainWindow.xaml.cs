using ProjectAstroClass.BackgroundClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectAstroClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Armor[] ArmorChoices = { };
        private Chassis[] ChassisChoices = { };
        private Utility[] UtilityChoices = { };
        private Weaponry[] WeaponryChoices = { };
        private Mobility[] MobilityChoices = { };
        private int[] Index = { };


        public MainWindow()
        {
            InitializeComponent();
            Drone drone = new Drone();
            this.DataContext = drone;
        }
        private void cboDroneMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


}
