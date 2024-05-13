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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        CoterieContext db = new();

        public OrderPage()
        {
            InitializeComponent();

            InitOrder();
        }

        private void InitOrder()
        {
            double totalMoney = 0.0f;

            cbTypes.ItemsSource = db.payMethod.ToList();

            var tempDel = Math.Round(new Random().Next(100, 200) + new Random().NextDouble(), 2);
            totalMoney += tempDel;
            tbDel.Text = tempDel.ToString();
            tbDisc.Text = db.profile.Where(x => x.id == MainWindow.curUser.profileId).Select(x => x.personalDiscount).FirstOrDefault().ToString();

            var tempOrderList = db.orderList.Where(x=>x.orderId==HomePage.curOrder.Id).ToList();

            List<Product> tempList = new();

            foreach(var tempOrder in tempOrderList)
            {
                var tempProduct = db.product.Where(x=>x.id== tempOrder.productId).FirstOrDefault();
                totalMoney += tempProduct.price;
                lbOrder.Items.Add(tempProduct);
            }

            tbTotal.Text = Math.Round(totalMoney, 2).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.GoBack();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new UserProfilePage());
        }

        private void lbOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Не удалось удалить товар из заказа", "Ошибка");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var newOrder = HomePage.curOrder;
            newOrder.date = DateTime.Now;
            newOrder.statusId = 2;
            newOrder.payMethod = cbTypes.SelectedItem as PayMethod;
            newOrder.user = MainWindow.curUser;
            db.order.Update(newOrder);
            db.SaveChanges();

            MessageBox.Show("Спасибо за заказ!");
            MainWindow.mainFrame.Navigate(new HomePage());
        }
    }
}
