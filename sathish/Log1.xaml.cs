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
using static System.Net.Mime.MediaTypeNames;

namespace sathish
{
    /// <summary>
    /// Interaction logic for Log1.xaml
    /// </summary>
    public partial class Log1 : Window
    {
      
        public Log1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Age = 2023 - Convert.ToInt32(txtyear.Text);
            txtyear.Text = Age.ToString();
            if(Age>25 && Age<30)
            {
                string OfferLetter1 = "Hi {name} Your age_{Age} " + " so you are graduated in {Qualification} And Your are early got a job super and achieve your expectations in your life all the best ";
                string value1 = OfferLetter1.Replace("{name}", txtname.Text);
                value1 = value1.Replace("{Age}", Age.ToString());
                value1 = value1.Replace("{Qualification}", txtqual.Text);
                //MessageBox.Show(value1);
                Home ohome = new Home();
                ohome.tblockwelcome.Text = value1;
                ohome.Show();
            }
            

            //string hi = "Hi " + txtname.Text + " Your are early got a job super and achieve your expectations all the best";
            //MessageBox.Show(hi);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int Age = 2023 - Convert.ToInt32(txtyear.Text);
            txtyear.Text = Age.ToString();

            if (Age > 20 && Age <= 23)
            {
                string OfferLetter1 = "Dear {name} Your age_{Age} " + " you're Fantastic listener good one choosing {Qualification} And Don't Waste Your Time and  your dream is Big so focus on the study only";
                string value = OfferLetter1.Replace("{name}", txtname.Text);
                value = value.Replace("{Age}", Age.ToString());
                 value = value.Replace("{Qualification}", txtqual.Text);
                //MessageBox.Show(value1);
                Home ohome = new Home();  
                ohome.tblockwelcome.Text = value;
                ohome.Show();
            }  
            else if(Age>23 && Age<25)
            {
                string OfferLetter1 = "Dear {name} Your age_{Age} " +" Nice to Meetyou Focus on Your career ";
                string value = OfferLetter1.Replace("{name}", txtname.Text);
                value = value.Replace("{Age}", Age.ToString());
                value = value.Replace("{Qualification}", txtqual.Text);
                //MessageBox.Show(value1);
                Home ohome = new Home();
                ohome.tblockwelcome.Text = value;
                ohome.Show();
            }

            //string oHi = "Hi " + txtname.Text + " Don't Waste Your Time and  your dream is Big so focus on the study only";
            //MessageBox.Show(oHi);            
        }
       
    }
}
