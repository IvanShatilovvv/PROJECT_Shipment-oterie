using Microsoft.Win32;
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
    /// Логика взаимодействия для UserProfilePage.xaml
    /// </summary>
    public partial class UserProfilePage : Page
    {
        CoterieContext db = new();

        public UserProfilePage()
        {
            InitializeComponent();

            InitInfo();
        }

        private void InitInfo()
        {
            try
            {
                Profile tempProfile = db.profile.Where(x => x.id == MainWindow.curUser.profileId).FirstOrDefault();

                tbName.Text = tempProfile.firstName;
                tbAdres.Text = tempProfile.adres;
                tbAge.Text = tempProfile.age.ToString();
                tbCard.Text = tempProfile.cardNumber.ToString();
                tbDiscount.Text = tempProfile.personalDiscount.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить профиль");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Вы уверены в том, что хотите выйти из учетной записи?","ВЫХОД", MessageBoxButton.YesNo);
            if(a==MessageBoxResult.Yes)
            {
                MainWindow.mainFrame.Navigate(new LoginPage());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Сохранить изменения?","Сохранение", MessageBoxButton.YesNo);
            if (a==MessageBoxResult.Yes)
            {
                Profile tempProfile = db.profile.Where(x => x.id == MainWindow.curUser.profileId).FirstOrDefault();

                try
                {
                    tempProfile.cardNumber = tbCard.Text;
                    tempProfile.adres = tbAdres.Text;

                    db.profile.Update(tempProfile);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            MainWindow.mainFrame.GoBack();
        }
    }
}
