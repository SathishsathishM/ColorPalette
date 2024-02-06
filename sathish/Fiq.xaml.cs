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
    /// Interaction logic for FIQ.xaml
    /// </summary>
    public partial class FIQ : Window
    {
        public FIQ()
        {
            InitializeComponent();
        }

        private void First_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue = Convert.ToInt32(lbl1.Content);
            if (checkBoxclick.Tag.ToString()== "1")
            {
                oldvalue =oldvalue+ 5;
            }
            else
            {
                oldvalue = oldvalue - 5;
            }
            lbl1.Content=oldvalue.ToString();
            checkBoxclick.IsEnabled = false;
        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue2 = Convert.ToInt32(lbl2.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue2 = oldvalue2 + 5;
            }
            else
            {
                oldvalue2 = oldvalue2 - 5;
            }
            lbl2.Content = oldvalue2.ToString();
            checkBoxclick.IsEnabled = false;
        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue3 = Convert.ToInt32(lbl3.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue3 = oldvalue3 + 5;
            }
            else
            {
                oldvalue3 = oldvalue3 - 5;
            }
            lbl3.Content = oldvalue3.ToString();
            checkBoxclick.IsEnabled = false;
        }

        private void Four_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue4 = Convert.ToInt32(lbl4.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue4 = oldvalue4 + 5;
            }
            else
            {
                oldvalue4 = oldvalue4 - 5;
            }
            lbl4.Content = oldvalue4.ToString();
            checkBoxclick.IsEnabled = false;
        }

        private void Five_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBoxclick = (CheckBox)sender;
            int oldvalue5 = Convert.ToInt32(lbl5.Content);
            if (checkBoxclick.Tag.ToString() == "1")
            {
                oldvalue5 = oldvalue5 + 5;
            }
            else
            {
                oldvalue5 = oldvalue5 - 5;
            }
            lbl5.Content = oldvalue5.ToString();
            checkBoxclick.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(lbl1.Content);
            int value1 = Convert.ToInt32(lbl2.Content);
            int value2 = Convert.ToInt32(lbl3.Content);
            int value3 = Convert.ToInt32(lbl4.Content);
            int value4 = Convert.ToInt32(lbl5.Content);
            lbl6.Content= value + value1 + value2 + value3 + value4;
            







        }
    }
}
