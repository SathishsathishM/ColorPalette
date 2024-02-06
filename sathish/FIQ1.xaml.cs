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

namespace sathish
{
    /// <summary>
    /// Interaction logic for FIQ1.xaml
    /// </summary>
    public partial class FIQ1 : Window
    {
        public FIQ1()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            FIQ fIQ = new FIQ();
            fIQ.txtbname.Text="Hi "+txtbname.Text+",";
            fIQ.Show();

            //FIQ ofIQ = new FIQ();
            //ofIQ.Show(); 

        }
    }
}
