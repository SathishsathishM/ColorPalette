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
    /// Interaction logic for Calc.xaml
    /// </summary>
    public partial class Calc : Window
    {
        string oper = "";
        string firstvalue = "";
        string secondvalue = "";
        public Calc()
        {
            InitializeComponent();
        }
       

        private void btnequal_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt32(firstvalue);
            int second = Convert.ToInt32(secondvalue);
            int result = 0;
            if (oper =="+")
            {                
                result = first + second;               
            }
           else if (oper =="-") 
            {
                result = first - second;   
            }
           else if(oper =="*")
            {               
                result = first * second;               
            }
            txtresult.Text = Convert.ToString(result);
        }
        private void oper_Click(object sender, RoutedEventArgs e)
        {
            Button Button = (Button) sender;
            oper = Button.Content.ToString();
           // txtresult.Clear();
        }
        //private void btnmult_Click(object sender, RoutedEventArgs e)
        //{
        //    oper ="*";
        //}

        //private void btnminus_Click(object sender, RoutedEventArgs e)
        //{
        //    oper ="-";
        //}
        private void Number_Click(object sender, RoutedEventArgs e)
        {

            Button btnnumber = (Button)sender;

            if (oper == "")
            {
                firstvalue = firstvalue + Convert.ToString(btnnumber.Content);
                txtresult.Text = firstvalue;
            }
            else
            {
                secondvalue = secondvalue + Convert.ToString(btnnumber.Content);
                txtresult.Text = secondvalue;
            }
        }
        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstvalue = firstvalue + Convert.ToString(btn2.Content);
        //        txtresult.Text = firstvalue;
        //    }
        //    else
        //    {
        //        secondvalue = secondvalue +Convert.ToString(btn2.Content);
        //        txtresult.Text = secondvalue;
        //    }
        //}       
        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            firstvalue = "";
            secondvalue = "";
            txtresult.Clear();
            oper = "";
        }
    }
}
