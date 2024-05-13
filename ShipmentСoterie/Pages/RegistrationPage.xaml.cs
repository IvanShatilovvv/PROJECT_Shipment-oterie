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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        CoterieContext db = new();

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            TryRegistrNewUser();
        }

        private void TryRegistrNewUser()
        {
            //db.user.Add(new() { login="m2", password="m2", email="manager2@help.food", role=db.role.Where(x=>x.Id==2).FirstOrDefault(), profile = new() { firstName="admin2" } });
            //db.SaveChanges();

            if(string.IsNullOrWhiteSpace(tbLogin.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Password) ||
                string.IsNullOrWhiteSpace(tbPassword2.Password))
            {
                MessageBox.Show("WHITESPACE error", "error");
                return;
            }

            foreach (var item in db.user)
            {
                if (item.login == tbLogin.Text || item.login == tbEmail.Text)
                {
                    MessageBox.Show("LOGIN and/or EMAIL error", "error");
                    return;
                }
            }

            if(tbPassword.Password!=tbPassword2.Password)
            {
                MessageBox.Show("PASSWORD error", "error");
                return;
            }

            Profile newProfile = new() { firstName=tbName.Text };
            db.profile.Add(newProfile);
            db.SaveChanges();
            User newUser = new() { login=tbLogin.Text, email=tbEmail.Text,
                password = tbPassword.Password, role = db.role.Where(x=>x.name=="client").FirstOrDefault(), profile=newProfile };
            db.user.Add(newUser);
            db.SaveChanges();

            MessageBox.Show("Аккаунт создан");
            MainWindow.mainFrame.GoBack();
        }

        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.GoBack();
        }
    }
}
