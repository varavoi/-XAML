using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_17._10._2022
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in BackForm.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Btn_Click;
                }
            }
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)sender).Content;
            if (str == "AC")
                TxtSHOW.Text = "";
            else if (str == "=")
                TxtSHOW.Text = new DataTable().Compute(TxtSHOW.Text, null).ToString();
            else
                TxtSHOW.Text += str;
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
