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
    /// Логика взаимодействия для EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        CoterieContext db = new();

        public EditProductPage()
        {
            InitializeComponent();

            InitItems();
        }

        private void InitItems()
        {
            cbType.ItemsSource = db.productType.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mainFrame.Navigate(new HomePage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files (*.JPG, *.PNG, | *.jpg; *.png;";
            if (fileDialog.ShowDialog() == true)
            {
                string fileName = fileDialog.FileName;
                image.Source = new BitmapImage(new Uri(fileName));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //  add new product
            if (db.shop.Where(x => x.name == tbShop.Text).FirstOrDefault() == null)
            {
                db.shop.Add(new() { name = tbShop.Text, description = "shop / megamarket / magazine", location = "н/д" });
                db.SaveChanges();
            }
            Product newPr = new() { name = tbName.Text, description = tbDesc.Text, price=float.Parse(tbPrice.Text), shop = db.shop.Where(x => x.name == tbShop.Text).First(),
                type = cbType.SelectedItem as ProductType, photo = image.Source.ToString() };
            db.product.Add(newPr);
            db.SaveChanges();
            MessageBox.Show("Окей");
        }
    }
}
