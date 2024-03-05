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

namespace WpfAppAuthorization
{
    /// <summary>
    /// Логика взаимодействия для WindowPracticalWork5.xaml
    /// </summary>
    public partial class WindowPracticalWork5 : Window
    {
        public WindowPracticalWork5()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x0 = double.Parse(txtX0.Text);
            double xk = double.Parse(txtXK.Text);
            double dx = double.Parse(txtDX.Text);
            double a = double.Parse(txtA.Text);
            double x = x0;
            while (x <= xk)
                {
                    double y = a * Math.Log(x);
                lstResult.Items.Add($"x = {Math.Round(x, 3)}  y = {Math.Round(y, 3)}");
                x += dx;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
