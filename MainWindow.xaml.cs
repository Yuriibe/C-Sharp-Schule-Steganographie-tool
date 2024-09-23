using System.Windows;

namespace SteganographyToolUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEncode_Click(object sender, RoutedEventArgs e)
        {
            // Load the EncodeUserControl into the ContentControl
            MainContent.Content = new EncodeControler();
        }


    }
}
