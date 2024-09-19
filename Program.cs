using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Load the image
        Bitmap image = new Bitmap("hund.png");

        // Loop through all rows and columns to change each pixel's color
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);


                image.SetPixel(x, y, Color.FromArgb(255, 200, 150));


                Console.WriteLine($"Modified Pixel at ({x}, {y}): Original Color = {pixel}, New Color = (255, 200, 150)");
            }
        }


        image.Save("output.png");


        image.Dispose();
    }
}
