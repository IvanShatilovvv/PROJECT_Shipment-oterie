using ShipmentСoterie.Tables;
using System.Windows;
using System.Windows.Controls;

namespace ShipmentСoterie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame mainFrame;
        public static User curUser;

        public MainWindow()
        {
            InitializeComponent();

            mainFrame = fMain;
            mainFrame.Navigate(new Pages.LoginPage());
        }
    }
}