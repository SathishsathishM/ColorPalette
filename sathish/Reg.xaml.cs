using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace sathish
{
    /// <summary>
    /// Interaction logic for Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("Hi welcome","Sathish", MessageBoxButton.YesNoCancel);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Selected yes");
            }
            else if (result == MessageBoxResult.No)
            {
                MessageBox.Show("Selected No");
            }
            else if (result == MessageBoxResult.Cancel)
            {
                MessageBox.Show("Selected Cancel");
            }



        }
    }
}
