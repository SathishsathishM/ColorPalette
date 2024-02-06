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
    /// Interaction logic for Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        string Username = "Sathish";
        string Password = "Admin";
        int Count = 0;

        public Log()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            //if(txtusername.Text==Username && pwdPassword.Password == Password)
            //{
            //    MessageBox.Show("Welcome");
            //}                                   
            if (txtusername.Text == Username && pwdPassword.Password == Password)
            {
                //string welcome = "Welcome " + txtusername.Text + " To Jsquare";
                //MessageBox.Show(welcome);
                Home ohome=new Home();
                ohome.tblockwelcome.Text = "Welcome " + txtusername.Text + " to jsquare";
                ohome.Show();
            }
            else  
            {                
                Count++;
                if (Count == 1)
                {
                    MessageBox.Show("Invalid username and password");
                }
                else if(Count == 2)
                {
                    MessageBox.Show("Second time is Wrong");
                }
                else if (Count == 3)
                {
                    MessageBox.Show("please Contact Your Admin");
                }
            }           
        }
          private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            Reg oreg = new Reg();
            oreg.Show();
        }
    }
}
