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
public partial class DecodeControler : UserControl
{
    private string selectedImagePath;
    private bool isDemo;

    public DecodeControler()
    {
        InitializeComponent();
    }

    private void ToggleSwitch_Checked(object sender, RoutedEventArgs e)
    {
        isDemo = true;
        MessageBox.Show("Demo mode Enabled");
    }

    private void ToggleSwitch_Unchecked(object sender, RoutedEventArgs e)
    {
        isDemo = false;
        MessageBox.Show("Demo mode Disabled");
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
            selectedImagePath = openFileDialog.FileName;
            BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog.FileName));
            imgDisplay.Source = bitmap;
            double result = (bitmap.Height * bitmap.Width * 3.0); // Ensure it's a double by using 3.0
            double roundedResult = Math.Floor(result);
            MessageBox.Show($"Total amount of available bits: {roundedResult.ToString()}");

        }

    }

    private void BtnDecodeImage(object sender, RoutedEventArgs e)
    {
        // Check if an image was uploaded
        if (!string.IsNullOrEmpty(selectedImagePath))
        {
            // Load the selected image as a Bitmap and encode it
            using (System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(selectedImagePath))
            {
                decodedText.Text = Decoder.Decode(bitmap);
            }
        }
        else
        {
            // Optionally, display an error message or notification that no image was selected
            MessageBox.Show("Please upload an image before encoding.");
        }

    }

}

