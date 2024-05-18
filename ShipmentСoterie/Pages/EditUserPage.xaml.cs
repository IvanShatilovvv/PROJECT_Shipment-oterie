using ShipmentСoterie.Tables;
using System.Windows;
using System.Windows.Controls;

namespace ShipmentСoterie.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        CoterieContext db = new();
        User curUser;

        public EditUserPage(User u)
        {
            InitializeComponent();

            curUser = u;            
            InitPage();

        }

        private void InitPage()
        {
            try
            {
                cbRole.ItemsSource = db.role.ToList();

                tbLogin.Text = curUser.login;
                tbEmail.Text = curUser.email;
                tbPass.Text = curUser.password;
                cbRole.SelectedItem = db.role.Where(x=>x.Id== curUser.roleId).FirstOrDefault();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            curUser.email = tbEmail.Text;
            curUser.password = tbPass.Text;
            curUser.roleId = (cbRole.SelectedItem as Role).Id;
            db.Update(curUser);
            db.SaveChanges();
            MessageBox.Show("Успешно изменено");
            MainWindow.mainFrame.Navigate(new UserAdministrationPage());
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Изменения будут утеряны", "Предупреждение", MessageBoxButton.YesNo);
            if(a==MessageBoxResult.Yes) MainWindow.mainFrame.Navigate(new UserAdministrationPage());
        }
    }
}
