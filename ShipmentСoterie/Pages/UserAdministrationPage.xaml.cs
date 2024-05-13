using ShipmentСoterie.Tables;
using System.Windows;
using System.Windows.Controls;

namespace ShipmentСoterie.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserAdministrationPage.xaml
    /// </summary>
    public partial class UserAdministrationPage : Page
    {
        CoterieContext db = new();

        public UserAdministrationPage()
        {
            InitializeComponent();

            InitPage();
        }

        private void InitPage()
        {
            dgMain.ItemsSource = db.user.ToList();

        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new HomePage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new AddNewUserPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new EditUserPage(dgMain.SelectedItem as User));
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PinCodeWindow confirm = new();
            confirm.ShowDialog();

            bool isOk = MainWindow.curUser.password==confirm.getPassword;
            if (!isOk)
            {
                MessageBox.Show("Подтверждение действия не удалось");
                return;
            }

            var tempUser = dgMain.SelectedItem as User;

            var a = MessageBox.Show($"Удалить пользователя [ {tempUser.login} ] ?", "Confirm", MessageBoxButton.YesNo);
            if(a==MessageBoxResult.Yes) db.user.Remove(tempUser);
            db.SaveChanges();
            dgMain.ItemsSource = db.user.ToList();
        }
    }
}
