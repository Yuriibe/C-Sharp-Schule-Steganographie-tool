using System;
using System.Drawing;
using System.Text;

public struct RGBBinary
{
    public string Red { get; set; }
    public string Green { get; set; }
    public string Blue { get; set; }

    public RGBBinary(string red, string green, string blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

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
                            RGBBinary binaryValues = GetPixelRGBBinary(image, x, y);
                            Console.WriteLine($"Pixel ({x},{y}) - R: {binaryValues.Red}, G: {binaryValues.Green}, B: {binaryValues.Blue}");

                            char redLSB = binaryValues.Red[binaryValues.Red.Length - 1];   // LSB of the Red component
                            char greenLSB = binaryValues.Green[binaryValues.Green.Length - 1]; // LSB of the Green component
                            char blueLSB = binaryValues.Blue[binaryValues.Blue.Length - 1];  // LSB of the Blue component

                            Console.WriteLine($"Red LSB: {redLSB}");
                            Console.WriteLine($"Green LSB: {greenLSB}");
                            Console.WriteLine($"Blue LSB: {blueLSB}");

                            binaryValues = ModifyLSB(binaryValues, '0', '1', '0');
                            Console.WriteLine($"Modified Pixel - R: {binaryValues.Red}, G: {binaryValues.Green}, B: {binaryValues.Blue}");

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

    public static string StringToBinary(string input)
    {

        StringBuilder binary = new StringBuilder();

        foreach (char character in input)
        {
            // Convert each character to its ASCII value, then to binary string (8-bit padded)
            binary.Append(Convert.ToString(character, 2).PadLeft(8, '0'));
        }

        return binary.ToString();


    }

    public static RGBBinary GetPixelRGBBinary(Bitmap image, int x, int y)
    {
        // Get the pixel color at the specified coordinates
        Color pixel = image.GetPixel(x, y);

        // Convert RGB values to binary and pad to 8 bits
        string redBinary = Convert.ToString(pixel.R, 2).PadLeft(8, '0');
        string greenBinary = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
        string blueBinary = Convert.ToString(pixel.B, 2).PadLeft(8, '0');

        // Return the binary values wrapped in an RGBBinary struct
        return new RGBBinary(redBinary, greenBinary, blueBinary);
    }

    public static RGBBinary ModifyLSB(RGBBinary binaryValues, char redNewLSB, char greenNewLSB, char blueNewLSB)
    {
        // Modify the LSB for the Red component
        char[] redBinaryArray = binaryValues.Red.ToCharArray();
        redBinaryArray[redBinaryArray.Length - 1] = redNewLSB;
        string modifiedRed = new string(redBinaryArray);

        // Modify the LSB for the Green component
        char[] greenBinaryArray = binaryValues.Green.ToCharArray();
        greenBinaryArray[greenBinaryArray.Length - 1] = greenNewLSB;
        string modifiedGreen = new string(greenBinaryArray);

        // Modify the LSB for the Blue component
        char[] blueBinaryArray = binaryValues.Blue.ToCharArray();
        blueBinaryArray[blueBinaryArray.Length - 1] = blueNewLSB;
        string modifiedBlue = new string(blueBinaryArray);

        // Return the modified RGBBinary struct with updated binary values
        return new RGBBinary(modifiedRed, modifiedGreen, modifiedBlue);
    }


}
