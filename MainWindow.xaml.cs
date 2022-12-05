using ProjectAstroClass.BackgroundClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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

        //====================
        //
        //  !IMPORTANT!
        // the only background classes being used are drone and component. The others do not matter. 
        // the only reason I have yet to remove them is in case they hold some vital function
        // and I really don't want that to just disappear.
        //
        // thanks for reading
        //
        //====================



        //Arrays
        //displayControls stores all the items, so that we don't have to read them in from other objects.
        UserControls.DisplayControl[] displayControls = new UserControls.DisplayControl[120];
            //droneControls stores all the controls that are currently being displayed.
        public UserControls.DisplayControl[] droneControls { get; set; } = new UserControls.DisplayControl[17];

        //
        public BackgroundClasses.Drone drone { get; set; }

        public MainWindow()
        {
            //base drone that stores the shit
            drone = new Drone("name",5,100,10); 
            InitializeComponent();
            DataContext = this;
            MainWindow ownerIn = this;

            int size = 120;

            //Display Controls (will expand after project)
            //all the names have d at the end to distinguish them
            //Chassis
            UserControls.DisplayControl Tempestd = new UserControls.DisplayControl("Tempest 50", "Permanent Module: Expert Repairs\n" +
                "Repairing can be done without materials,\n" +
                "although unable to repair damage.", size, 1 ,'C', ref ownerIn);
            UserControls.DisplayControl Accessd = new UserControls.DisplayControl("77 Access", "Permanent Module: Anti-Virus Software\n " +
                "Keeps your drone safe from malware and viruses\n" +
                "while interacting with unknown systems.", size, 2,'C', ref ownerIn);
            UserControls.DisplayControl Streakerd = new UserControls.DisplayControl("Streaker Alpha", "[insert desc here]", size, 3, 'C', ref ownerIn);
            UserControls.DisplayControl Maelstromd = new UserControls.DisplayControl("Maelstrom X70", "[insert desc here]", size, 4, 'C', ref ownerIn);
            UserControls.DisplayControl ClockTowerd = new UserControls.DisplayControl("Clock Tower", "[insert desc here]", size, 5, 'C', ref ownerIn);
            UserControls.DisplayControl DoubleTeamd = new UserControls.DisplayControl("DTT (Double Team) Barge", "[insert desc here]", size, 6, 'C', ref ownerIn);
            //Utilities 
            UserControls.DisplayControl VISPd = new UserControls.DisplayControl("Variable Intra-strata Processor", "[insert desc here]", size, 1011, 'M', ref ownerIn);
            UserControls.DisplayControl EFMUd = new UserControls.DisplayControl("Emergency Field Maintenance Unit", "[insert desc here]", size, 1012, 'M', ref ownerIn);
            UserControls.DisplayControl Auxd = new UserControls.DisplayControl("Auxiliary Capacitor", "[insert desc here]", size, 1013, 'M', ref ownerIn);
            UserControls.DisplayControl Bankd = new UserControls.DisplayControl("Power Bank", "[insert desc here]", size, 1014, 'M', ref ownerIn);
            UserControls.DisplayControl Plugd = new UserControls.DisplayControl("Interface Control Plug", "[insert desc here]", size, 1015, 'M', ref ownerIn);
            //Mobility
            UserControls.DisplayControl Wheelsd = new UserControls.DisplayControl("Wheels/Treads", "[insert desc here]", size, 1021, 'M', ref ownerIn);
            UserControls.DisplayControl Limbsd = new UserControls.DisplayControl("Limbs", "[insert desc here]", size, 1022, 'M', ref ownerIn);
            UserControls.DisplayControl Tetherd = new UserControls.DisplayControl("Tether", "[insert desc here]", size, 1023, 'M', ref ownerIn);
            UserControls.DisplayControl RCSd = new UserControls.DisplayControl("Reaction Control System", "[insert desc here]", size, 1024, 'M', ref ownerIn);
            //Weaponry
            UserControls.DisplayControl Welrodd = new UserControls.DisplayControl("Welrod", "[insert desc here]", size, 1031, 'M', ref ownerIn);
            UserControls.DisplayControl Freizard = new UserControls.DisplayControl("Freizar", "[insert desc here]", size, 1032, 'M', ref ownerIn);
            UserControls.DisplayControl Sieged = new UserControls.DisplayControl("Siege", "[insert desc here]", size, 1033, 'M', ref ownerIn);
            UserControls.DisplayControl Flakd = new UserControls.DisplayControl("Flak", "[insert desc here]", size, 1034, 'M', ref ownerIn);
            UserControls.DisplayControl Pumpd = new UserControls.DisplayControl("Pump", "[insert desc here]", size, 1035, 'M', ref ownerIn);
            //Armor
            UserControls.DisplayControl Opend = new UserControls.DisplayControl("Open Wiring", "[insert desc here]", size, 11, 'A', ref ownerIn);
            UserControls.DisplayControl Carbond = new UserControls.DisplayControl("Carbon Fiber Shell", "[insert desc here]", size, 12, 'A', ref ownerIn);
            UserControls.DisplayControl Steeld = new UserControls.DisplayControl("Aluminum Plating", "[insert desc here]", size, 13, 'A', ref ownerIn);
            UserControls.DisplayControl Heavyd = new UserControls.DisplayControl("Thick Steel Armor", "[insert desc here]", size, 14, 'A', ref ownerIn);
            UserControls.DisplayControl SPAd = new UserControls.DisplayControl("Shockproof Protection Plates", "[insert desc here]", size, 15, 'A', ref ownerIn);

            //adding all displays to array
            displayControls[0] = Tempestd;
            displayControls[1] = Accessd;
            displayControls[2] = Streakerd;
            displayControls[3] = Maelstromd;
            displayControls[4] = ClockTowerd;
            displayControls[5] = DoubleTeamd;
            displayControls[6] = VISPd;
            displayControls[7] = EFMUd;
            displayControls[8] = Auxd;
            displayControls[9] = Bankd;
            displayControls[10] = Plugd;
            displayControls[11] = Wheelsd;
            displayControls[12] = Limbsd;
            displayControls[13] = Tetherd;
            displayControls[14] = RCSd;
            displayControls[15] = Welrodd;
            displayControls[16] = Freizard;
            displayControls[17] = Sieged;
            displayControls[18] = Flakd;
            displayControls[19] = Pumpd;
            displayControls[20] = Opend;
            displayControls[21] = Carbond;
            displayControls[22] = Steeld;
            displayControls[23] = Heavyd;
            displayControls[24] = SPAd;

            //TEST

        }

        /// <summary>
        /// Call this whenever a displayed value changes
        /// </summary>
        public void UpdateDisplay()
        {
            outList.Children.Clear();
            for (int i = 0; i< droneControls.Length;i++) {
                if (droneControls[i] != null)
                {
                    outList.Children.Add(droneControls[i]);
                }
            }
        }
        
        /// <summary>
        /// Creates a new display object to be added and stored in 
        /// droneControl. Also adds a component object to Drone.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="direction"></param>
        /// <param name="type"></param>
        public void addDronePart(int index, char direction, char type)
        {
            switch(type){ //these loops are all long and complicated. Don't touch them.
                case 'M':
                    {
                        bool success = false;

                        int inDex = 0;
                        for (int i = 0; i < droneControls.Length; i++)
                        {
                            if (droneControls[i] == null)
                            {
                                inDex = i;
                                for (int i2 = 0; i2 < displayControls.Length; i2++)
                                {
                                    if (displayControls[i2] == null)
                                    {

                                    }
                                    else
                                    {
                                        if (displayControls[i2].Index == index)
                                        {
                                            MainWindow ownerIn = this;
                                            UserControls.DisplayControl d = new UserControls.DisplayControl(displayControls[i2].Title,
                                                displayControls[i2].Description, displayControls[i2].DispHeight,
                                                displayControls[i2].Index, displayControls[i2].Type, ref ownerIn);
                                            d.I2 = inDex;
                                            droneControls[i] = d;
                                            
                                            success = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (success)
                            {
                                break;
                            }
                        }
                        Component component = new Component(index, inDex, direction);
                        drone.AddModule(component);
                        break;
                    }
                    //chassis
                case 'C':
                    {
                        int inDex = 0;
                        bool success = false;
                        for (int i = 0; i < droneControls.Length; i++)
                        {
                            if (droneControls[i] == null)
                            {
                                inDex = i;
                                for (int i2 = 0; i2 < displayControls.Length; i2++)
                                {
                                    if (displayControls[i2] == null)
                                    {

                                    }
                                    else
                                    {
                                        if (displayControls[i2].Index == index)
                                        {
                                            MainWindow ownerIn = this;
                                            UserControls.DisplayControl d = new UserControls.DisplayControl(displayControls[i2].Title,
                                                displayControls[i2].Description, displayControls[i2].DispHeight,
                                                displayControls[i2].Index, displayControls[i2].Type, ref ownerIn);
                                            d.I2 = inDex;
                                            droneControls[i] = d;
                                            success = true;
                                            break;
                                        }
                                    }
                                    
                                }
                            }
                            if (success)
                            {
                                break;
                            }
                        }
                        Component component = new Component(index, inDex, direction);
                        drone.AddChassis(component);
                        CMenu.IsEnabled = false;
                        break;
                    }
                case 'A':
                    {
                        int inDex = 0;
                        bool success = false;
                        for (int i = 0; i < droneControls.Length; i++)
                        {
                            if (droneControls[i] == null)
                            {
                                inDex = i;
                                for (int i2 = 0; i < displayControls.Length; i2++)
                                {
                                    if (displayControls[i2] == null)
                                    {

                                    }
                                    else
                                    {
                                        if (displayControls[i2].Index == index)
                                        {
                                            MainWindow ownerIn = this;
                                            UserControls.DisplayControl d = new UserControls.DisplayControl(displayControls[i2].Title,
                                                displayControls[i2].Description, displayControls[i2].DispHeight,
                                                displayControls[i2].Index, displayControls[i2].Type, ref ownerIn);
                                            d.I2 = inDex;
                                            droneControls[i] = d;
                                            success = true;
                                            break;
                                        }
                                    }
                                }
                            }
                            if (success)
                            {
                                break;
                            }
                        }
                        Component component = new Component(index, inDex, direction);
                        drone.AddArmor(component);
                        break;
                    }

            }
            UpdateDisplay();
        }
        /// <summary>
        /// !!!DO NOT USE THIS UNTIL DRONE AND OTHER THINGS ARE FIXED!!!
        /// </summary>
        /// <returns></returns>
        private char GetSide()
        {
            char cSide = ' ';
            inerPop.chosen = false;
            bool openSide = false;
            directionPopup.IsOpen = true;
            while (!inerPop.chosen && !openSide)
            {
                if (inerPop.chosen)
                {
                    bool check = drone.CheckSidesMod(inerPop.Direction);
                    if (check)
                    {
                        cSide = inerPop.Direction;
                        openSide = true;
                    }
                    else
                    {
                        inerPop.chosen = false;
                    }
                }
                else
                {

                }
            }
            directionPopup.IsOpen = false;
            return cSide;
        }
        /// <summary>
        /// Removes the display object and correlated component.
        /// </summary>
        /// <param name="index"></param>
        public void remove(int index)
        {
            droneControls[index].removed = true; // this allows the component to be identified and removed.
            
            //this next part is simply to remove the component from drone
            if (droneControls[index].Type == 'C')
            {
                drone.Chassis = null;
                drone.chassisChosen = false;
                drone.PropertyHasChanged("chassisChosen");
                CMenu.IsEnabled = true;
                for(int i = 0; i < droneControls.Length; i++)
                {
                    droneControls[i] = null;
                }
            }
            else if (droneControls[index].Type == 'M')
            {
                for (int j = 0; j < drone.Modules.Length; j++)
                {
                    if (drone.Modules[j] != null)
                    {
                        if (drone.Modules[j].indexD == droneControls[index].I2)
                        {
                            drone.Modules[j] = null;
                            drone.sidesLeft++;
                            drone.PropertyHasChanged("sidesLeft");
                        }
                    }
                }
            }
            else if (droneControls[index].Type == 'A')
            {
                for (int j = 0; j < drone.Armors.Length; j++)
                {
                    if (drone.Armors[j] != null)
                    {
                        if (drone.Armors[j].indexD == droneControls[index].I2)
                        {
                            drone.Armors[j] = null;
                            drone.armorLeft++;
                            drone.PropertyHasChanged("armorLeft");
                        }
                    }
                }
            }

            droneControls[index] = null;
            UpdateDisplay();
        }
        /// <summary>
        /// relic of old code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboDroneMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// would matter if we had time but doesn't
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// lmao doesn't work yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBuild(object sender, RoutedEventArgs e)
        {

        }

        /*
         * Aight, these next sections are all the events for each item in the menus.
         * Each are almost identical aside from their type and index. 
         * 
         * This is generally what a module event would look like:
         * 
          
            int cIndex = 1023; // this index represents what object in the array displayControls is being referenced.
            char cType = 'M'; // this is the type. 'M' for modules, 'C' for chassis, and 'A' for armors.
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();  // unfortunately this is not in a working state right now. The code is all there, but the stuff it relies on is not. RIP
                addDronePart(cIndex, cSide, cType);
            }
          
         *
         * use this as a basis for adding new itens.
        */

        // Modules
        private void CoreProt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BCC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VISP_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1011;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void EFMU_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1012;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void AuxCap_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1013;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void PowBank_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1014;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void ICP_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1015;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
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
            int cIndex = 1021;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Limbs_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1022;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Tether_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1023;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void RCS_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1024;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Laser_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1035;
            char cType = 'M';
            char cSide = ' ';
            cSide = GetSide();

            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }


        }

        private void Welrod_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1031;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Freizar_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1032;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Siege_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1033;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void Flak_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1034;
            char cType = 'M';
            char cSide = ' ';
            if (drone.sidesLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void TE_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 1;
            char cType = 'C';
            addDronePart(cIndex,' ','C');
        }

        private void AC_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 2;
            char cType = 'C';
            addDronePart(cIndex, ' ', 'C');

        }

        private void ST_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 3;
            char cType = 'C';
            addDronePart(cIndex, ' ', 'C');

        }

        private void MA_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 4;
            char cType = 'C';
            addDronePart(cIndex, ' ', 'C');

        }

        private void CL_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 5;
            char cType = 'C';
            addDronePart(cIndex, ' ', 'C');

        }

        private void DTT_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 6;
            char cType = 'C';
            addDronePart(cIndex, ' ', 'C');

        }

        private void OW_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 11;
            char cType = 'A';
            char cSide = ' ';
            if (drone.armorLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void CFS_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 12;
            char cType = 'A';
            char cSide = ' ';
            if (drone.armorLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void AP_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 13;
            char cType = 'A';
            char cSide = ' ';
            if (drone.armorLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void TSA_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 14;
            char cType = 'A';
            char cSide = ' ';
            if (drone.armorLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void SPP_Click(object sender, RoutedEventArgs e)
        {
            int cIndex = 15;
            char cType = 'A';
            char cSide = ' ';
            if (drone.armorLeft == 0)
            {

            }
            else
            {
                //cSide = GetSide();
                addDronePart(cIndex, cSide, cType);
            }
        }

        private void HA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void APA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RA2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Achi_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
