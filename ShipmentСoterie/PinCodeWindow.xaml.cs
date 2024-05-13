using System.Windows;

namespace ShipmentСoterie
{
    /// <summary>
    /// Логика взаимодействия для PinCodeWindow.xaml
    /// </summary>
    public partial class PinCodeWindow : Window
    {
        public string getPassword;

        public PinCodeWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getPassword = tbPas.Password;
            this.Close();
        }
    }
}
