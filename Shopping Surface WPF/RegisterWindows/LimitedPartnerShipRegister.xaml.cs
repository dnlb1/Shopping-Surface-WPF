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

namespace Shopping_Surface_WPF.RegisterWindows
{
    /// <summary>
    /// Interaction logic for LimitedPartnerShipRegister.xaml
    /// </summary>
    public partial class LimitedPartnerShipRegister : Window
    {
        public LimitedPartnerShipRegister()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lb.Items.Clear();
            Label l = new Label();
            l.Content = "Termék hozzáadva!";
            Lb.Items.Add(l);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
