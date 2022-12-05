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
using System.Windows.Shapes;

namespace ProjectAstroClass.UserControls
{
    /// <summary>
    /// Interaction logic for DisplayControl.xaml
    /// </summary>
    public partial class DisplayControl : UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DispWidth { get; set; } = 80;
        public int DispHeight { get; set; } = 30;
        public string TitleWidth { get; set; } = "Auto";
        public char Type { get; set; }
        public bool removed { get; set; } = false;
        public int Index { get; set; }

        public int I2 { get; set; }
        private MainWindow owner { get; set; }


        public DisplayControl(string title, string description, int dispHeight, int index, char type, ref MainWindow create)
        {
            Title = title;
            Description = description;
            DispHeight = dispHeight;
            Index = index;
            Type = type;
            owner = create;
            InitializeComponent();

            DataContext = this;
        }

        public void setI2(int i2)
        {
            I2 = i2;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            removed = true;
            owner.remove(I2);
        }
    }
}
