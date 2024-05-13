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
using System.Xml.Linq;

namespace ShipmentСoterie.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddNewUserPage.xaml
    /// </summary>
    public partial class AddNewUserPage : Page
    {
        CoterieContext db = new();

        public AddNewUserPage()
        {
            InitializeComponent();

            cbRole.ItemsSource = db.role.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PinCodeWindow confirm = new();
            confirm.ShowDialog();

            bool isOk = MainWindow.curUser.password == confirm.getPassword;
            if (!isOk)
            {
                MessageBox.Show("Подтверждение действия не удалось");
                return;
            }

            try
            {
                Profile newProfile = new() { firstName = "н/д" };
                db.profile.Add(newProfile);
                db.SaveChanges();

                User newUser = new() { login=tbLogin.Text, email=tbEmail.Text, password=tbPass.Text, role=cbRole.SelectedItem as Role, profile=newProfile };
                db.user.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Успешное добавление");
                MainWindow.mainFrame.Navigate(new UserAdministrationPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Изменения будут утеряны", "", MessageBoxButton.YesNo);
            if (a == MessageBoxResult.Yes)
            {
                MainWindow.mainFrame.Navigate(new UserAdministrationPage());
            }
        }
    }
}
