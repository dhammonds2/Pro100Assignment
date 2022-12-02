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

        Drone drone;// = new Drone();

        public MainWindow()
        {
            drone = new Drone(); 
            InitializeComponent();
            this.DataContext = drone;
        }


        private void cboDroneMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void saveBuild(object sender, RoutedEventArgs e)
        {

        }
        private static String Search(object value)
        {
            Drone drone = new Drone();
            Boolean quit = false;
            String searchString = "";


            int selection = Int32.Parse(searchString);
            while (!quit)
            {
                switch (selection)
                {
                    case 0:
                        drone.AddModule();
                        break;
                    case 1:
                        drone.AddChassis();
                        break;
                    case 2:
                        drone.AddArmor();
                        break;
                    case 3:
                        drone.CheckSides();
                        break;



                }
            }
        }


}
