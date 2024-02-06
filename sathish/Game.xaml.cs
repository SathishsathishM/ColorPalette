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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        int count = 0;
        public Game()
        {
            InitializeComponent();
       }

        private void Common_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Button btnbox = (Button)sender;
            btnbox.Content = btnbox.Tag;
            btnbox.IsEnabled = false;
            if(lblname1.Tag.ToString()=="1")
            {

                int prevamount = Convert.ToInt32(txtbamount1.Text);
                int currentamount=Convert.ToInt32(btnbox.Tag);
                int totalamount = prevamount + currentamount;
                txtbamount1.Text=totalamount.ToString();
                btnbox.Foreground=txtbamount1.Foreground;
                lblname1.Tag = "0";
                lblname2.Tag = "1";
            }
            else if(lblname2.Tag.ToString()=="1")
            {
                int prevamount = Convert.ToInt32(txtbamount2.Text);
                int currentamount = Convert.ToInt32(btnbox.Tag);
                int totalamount = prevamount + currentamount;
                txtbamount2.Text = totalamount.ToString();
                btnbox.Foreground = txtbamount2.Foreground;
                lblname1.Tag = "1";
                lblname2.Tag = "0";
            }
            if(count==10)
            {
                int sathish = Convert.ToInt32(txtbamount1.Text);
                int vishnu = Convert.ToInt32(txtbamount2.Text);
                if(sathish>vishnu)
                {
                    //MessageBox.Show(lblname1.Content +" is Winner");
                    Home ohome = new Home();
                    ohome.tblockwelcome.Text = lblname1.Content+" is Winner";
                    ohome.Show();
                }
                else
                {
                    //MessageBox.Show(lblname2.Content + " is Winner");
                    Home ohome = new Home();
                    ohome.tblockwelcome.Text = lblname2.Content + " is Winner";
                    ohome.Show();
                }
            }
           
        }
    }
}
