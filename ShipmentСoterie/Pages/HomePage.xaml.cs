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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        CoterieContext db = new();
        public static Order curOrder;

        public HomePage()
        {
            InitializeComponent();

            InitGoods();
        }

        private void InitGoods()
        {
            curOrder = new() { date = DateTime.Now, payMethod = db.payMethod.Where(x=>x.id==1).FirstOrDefault(), 
                status=db.orderStatus.Where(x=>x.id==1).FirstOrDefault(), userId=MainWindow.curUser.Id };
            db.order.Add(curOrder);
            db.SaveChanges();

            lbMain.ItemsSource = db.product.ToList();
        }

        private void FoodButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new UserProfilePage());
        }

        private void lbMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db.orderList.Add(new() { order = curOrder, productId = (lbMain.SelectedItem as Product).id });
            db.SaveChanges();
            MessageBox.Show("Товар добавлен в ваш заказ", "Успешно");
            //MessageBox.Show(((ListBox)sender).SelectedItem.ToString());
            //OrderList newFood = new() { order=curOrder, product= };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = sender as Button;
            var b = a.Parent;
            MessageBox.Show(b.ToString());
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            if(MainWindow.curUser.roleId==1)
            {
                MainWindow.mainFrame.Navigate(new UserAdministrationPage());
            }
            if(MainWindow.curUser.roleId==2)
            {
                MainWindow.mainFrame.Navigate(new EditProductPage());
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new OrderPage());
        }
    }
}
