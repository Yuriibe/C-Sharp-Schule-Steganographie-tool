using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace SteganographyToolUI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        // string inputText = InputTextBox.Text;
        // System.Console.WriteLine($"You entered: {inputText}");
        // Encoder.Encode(inputText);
        //  Decoder.Decode();
    }

    private void BtnUploadImage_Click(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Image files (*.png)|*.png"

        };

        /**
                               ^
                               |
                               |
                               |
                            Is the same 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png)|*.png";

        **/


        if (openFileDialog.ShowDialog() == true)
        {
            BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
            imgDisplay.Source = bitmap;
        }

    }

}

