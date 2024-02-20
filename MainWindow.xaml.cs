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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppAuthorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //comment
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = psbPassword.Password;
            if (string.IsNullOrEmpty(login) ) // если поле логина пустое
            {
                MessageBox.Show("Введите логин");
                return;
            }
            else
                if (string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            else
                if (login.ToLower() == "admin")
                    if (password.ToLower() == "123") 
                        {
                            MessageBox.Show("Вы авторизованы успешно");
                        }
                    else 
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                else
                    
                    {
                MessageBox.Show("Неверный логин");
            }
        }
    }
}
