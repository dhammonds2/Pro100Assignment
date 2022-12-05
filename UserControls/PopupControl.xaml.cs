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
    /// Interaction logic for PopupControl.xaml
    /// </summary>
    public partial class PopupControl : UserControl
    {
        public char Direction { get; set; }
        public bool chosen { get; set; } = false;
        public PopupControl()
        {
            InitializeComponent();
        }

        private void Front_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'F';
            chosen = true;
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'L';
            chosen = true;
        }

        private void Top_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'T';
            chosen = true;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'B';
            chosen = true;
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'R';
            chosen = true;
        }

        private void Bottom_Click(object sender, RoutedEventArgs e)
        {
            Direction = 'U';
            chosen = true;
        }
    }
}
