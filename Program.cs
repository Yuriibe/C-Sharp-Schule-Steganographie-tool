using System;
using System.Drawing;
using System.Text;
class Program
{
    static void Main(string[] args)
    {

        Bitmap image = new Bitmap("hund.png");

        if (true)
        {
            for (int y = 0; y < image.Height; y++)
            {
                if (y < 1)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        if (x < 1)
                        {
                            Color pixel = image.GetPixel(x, y);

                            // Convert RGB values to binary
                            string redBinary = Convert.ToString(pixel.R, 2).PadLeft(8, '0');
                            string greenBinary = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
                            string blueBinary = Convert.ToString(pixel.B, 2).PadLeft(8, '0');

                            Console.WriteLine($"redBinary {redBinary}");
                            // Print or use the binary RGB values
                            Console.WriteLine($"Pixel ({x},{y}) - R: {redBinary}, G: {greenBinary}, B: {blueBinary}");


                            // image.SetPixel(x, y, Color.FromArgb(255, 200, 150));


                            // Console.WriteLine($"Modified Pixel at ({x}, {y}): Original Color = {pixel}, New Color = (255, 200, 150)");
                        }
                    }
                }
            }

        }

        string input = "Hello World";
        string binaryString = StringToBinary(input);
        Console.WriteLine($"Binary representation of '{input}' is: {binaryString}");
        image.Save("output.png");


        image.Dispose();
    }

    static string StringToBinary(string input)
    {

        StringBuilder binary = new StringBuilder();

        foreach (char c in input)
        {
            // Convert each character to its ASCII value, then to binary string (8-bit padded)
            binary.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }

        return binary.ToString();


    }
}
