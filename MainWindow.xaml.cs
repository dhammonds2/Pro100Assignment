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
        //Arrays
        private Armor[] ArmorChoices = {  };
        private Chassis[] ChassisChoices = { };
        private Utility[] UtilityChoices = { };
        private Weaponry[] WeaponryChoices = { };
        private Mobility[] MobilityChoices = { };
        private int[] Index = { };

        Drone drone;// = new Drone();

        public MainWindow()
        {
            drone = new Drone("name",5,100,10); 
            InitializeComponent();
            DataContext = drone;

            //armors
            Armor OpenWiring = new Armor("Open Wiring", 1, "No armor. Very light.", 0, 0, 0 );
            Armor CarbonFiber = new Armor("Carbon Fiber Shell", 2, "A light solution for protection.", 10, 12, 3);
            Armor Aluminum = new Armor("Aluminum Plating", 3, "Standard Drone Armor.", 50, 6, 10);
            Armor Steel = new Armor("Thick Steel Armor", 4, "A good defensive option.", 200, 18, 12);
            Armor SPA = new Armor("Shockproof Protection Plates", 5, "Rubber insulation protects from electricity.", 300, 6, 8);
            Armor Heavy = new Armor("Heavy Armor", 6, "Made of titanium, a very sturdy material.", 400, 30, 20);
            Armor APA = new Armor("Aluminum Plating", 7, "Standard Drone Armor.", 50, 6, 10);
            Armor Reactive = new Armor("Aluminum Plating", 8, "Standard Drone Armor.", 50, 6, 10);
            Armor Energy = new Armor("Aluminum Plating", 9, "Standard Drone Armor.", 50, 6, 10);
            Armor Reactive2 = new Armor("Aluminum Plating", 10, "Standard Drone Armor.", 50, 6, 10);
            Armor Achilles = new Armor("Aluminum Plating", 11, "Standard Drone Armor.", 50, 6, 10);
            ArmorChoices[0] = OpenWiring;
            ArmorChoices[1] = CarbonFiber;
            ArmorChoices[2] = Aluminum;
            ArmorChoices[3] = Steel;
            ArmorChoices[4] = SPA;
            ArmorChoices[5] = Heavy;
            ArmorChoices[6] = APA;
            ArmorChoices[7] = Reactive;
            ArmorChoices[8] = Energy;
            ArmorChoices[9] = Reactive2;
            ArmorChoices[10] = Achilles;
            //enough for now

            //I'm not filling in everything rn
            //Modules
                //Utility
            Module VISP = new Module("V.I.S.P.", 201,"Aim better lmao",5,150);
            Module EFMU = new Module("E.F.M.U.", 202,"Self Repairs at a high cost",5,150);
            Module Aux = new Module("Auxiliary Capacitor", 203,"Burst of Power",5,150);
            Module Pow = new Module("Power Bank", 204,"Extra Power",5,150);
            Module Plug = new Module("Interface Control Plug", 205,"Use computer",5,150);
            Module Alternator = new Module("Kinetic Alternator", 206,"Move freely",5,150);
            Module Saw = new Module("Angle Saw", 207,"Cut debris and other things",5,150);
            Module Wiring = new Module("Wiring Kit", 208,"Repair electronics",5,150);

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

        private void CoreProt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VISP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EFMU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AuxCap_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PowBank_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ICP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void KinAlt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AngleSaw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WiringTool_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoudSpeak_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlasmaCut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ESU_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Compress_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Weld_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Claw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Packets_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fluid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fuel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nodes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ammo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bio_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Motion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Bumper_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Projector_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Shield_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Box_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Foundry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Geiger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Spinners_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Limbs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tether_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RCS_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Laser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Welrod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Freizar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Siege_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Flak_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
