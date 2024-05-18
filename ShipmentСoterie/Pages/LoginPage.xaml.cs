using ShipmentСoterie.Tables;
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

namespace ShipmentСoterie.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        CoterieContext db = new();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new RegistrationPage());
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User cur = new() { login=tbLogin.Text, password=tbPassword.Password };

            foreach (var item in db.user)
            {
                if(item.login==cur.login)
                {
                    if (item.password == cur.password)
                    {
                        MainWindow.curUser = item;
                        MainWindow.mainFrame.Navigate(new HomePage());
                        return;
                    }
                }
            }
            MessageBox.Show("Вход не удался", "Ошибка");
        }
    }
}
