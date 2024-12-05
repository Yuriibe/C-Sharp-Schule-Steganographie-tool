using System;
using System.Drawing;
using System.Text;

public struct RGBBinary
{
    public string Red { get; set; }
    public string Green { get; set; }
    public string Blue { get; set; }

    // creating a new struct to later save our RGBBinary in
    public RGBBinary(string red, string green, string blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
}

public class Encoder
{
    public static void Encode(string input, Bitmap image, bool demo = false)
    {
        string binaryString = StringToBinary(input);

        int totalBits = binaryString.Length;

        int bitIndex = 0;

        int totalBitsImage = image.Height * image.Width * 3;

        if (totalBits > totalBitsImage)
        {
            return;
        }

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {

                if (bitIndex >= totalBits)
                {
                    break; // Exit the inner loop
                }

                RGBBinary binaryValues = GetPixelRGBBinary(image, x, y);

                Console.WriteLine($"Pixel ({x},{y}) - R: {binaryValues.Red}, G: {binaryValues.Green}, B: {binaryValues.Blue}");


                // Assign the least significant bit (LSB) for each color channel (red, green, blue) from the binaryString.
                // If there are still bits available (bitIndex < totalBits), take the next bit from binaryString and increment bitIndex.
                // If no bits are left, assign a default value of '0' to the respective channel.

                char redLSB = (bitIndex < totalBits) ? binaryString[bitIndex++] : '0';
                char greenLSB = (bitIndex < totalBits) ? binaryString[bitIndex++] : '0';
                char blueLSB = (bitIndex < totalBits) ? binaryString[bitIndex++] : '0';

                Console.WriteLine($"Red LSB: {redLSB}");
                Console.WriteLine($"Green LSB: {greenLSB}");
                Console.WriteLine($"Blue LSB: {blueLSB}");

                // Check if the program is in demo mode. If true, call ModifyLSB with an additional parameter (8) for demonstration purposes.
                // Otherwise, call ModifyLSB with the default parameters to embed the LSB values into the binary representation of the pixel colors.
                binaryValues = demo
                    ? ModifyLSB(binaryValues, redLSB, greenLSB, blueLSB, 8)
                    : ModifyLSB(binaryValues, redLSB, greenLSB, blueLSB);
                Console.WriteLine($"Modified Pixel - R: {binaryValues.Red}, G: {binaryValues.Green}, B: {binaryValues.Blue}");

                // Convert the modified binary values back to a Color object and update the pixel at position (x, y) in the image.
                // This step ensures the modified pixel is written back to the image with the new color values. 
                Color newRGBColor = BinaryToInt(binaryValues);
                image.SetPixel(x, y, newRGBColor);

            }

            if (bitIndex >= totalBits)
            {
                Console.WriteLine("Finished hiding all bits in the image.");
                break; // Exit the inner loop
            }

        }

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

    public static Color BinaryToInt(RGBBinary rGBBinary)
    {
        // Convert the binary string to an integer.
        int red = Convert.ToInt32(rGBBinary.Red, 2);
        int green = Convert.ToInt32(rGBBinary.Green, 2);
        int blue = Convert.ToInt32(rGBBinary.Blue, 2);

        // Create a Color object using the converted RGB values.
        Color color = Color.FromArgb(red, green, blue);

        Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");
        Console.WriteLine($"Color: {color}");

        return color;
    }

    public static RGBBinary GetPixelRGBBinary(Bitmap image, int x, int y)
    {
        // Get the pixel color at the specified coordinates
        Color pixel = image.GetPixel(x, y);

        // grabbing the Red color channel of the pixel turning it to base 2 and add leading 0 to confirm we have 8 bits
        string redBinary = Convert.ToString(pixel.R, 2).PadLeft(8, '0'); 
        string greenBinary = Convert.ToString(pixel.G, 2).PadLeft(8, '0');
        string blueBinary = Convert.ToString(pixel.B, 2).PadLeft(8, '0');

        // Return the binary values wrapped in our RGBBinary struct
        return new RGBBinary(redBinary, greenBinary, blueBinary);
    }

    public static RGBBinary ModifyLSB(RGBBinary binaryValues, char redNewLSB, char greenNewLSB, char blueNewLSB, int indexOffset = 1)
    {
        // Modify the LSB for the Red component
        char[] redBinaryArray = binaryValues.Red.ToCharArray();
        redBinaryArray[redBinaryArray.Length - indexOffset] = redNewLSB; 
        string modifiedRed = new string(redBinaryArray);

        // Modify the LSB for the Green component
        char[] greenBinaryArray = binaryValues.Green.ToCharArray();
        greenBinaryArray[greenBinaryArray.Length - indexOffset] = greenNewLSB;
        string modifiedGreen = new string(greenBinaryArray);

        // Modify the LSB for the Blue component
        char[] blueBinaryArray = binaryValues.Blue.ToCharArray();
        blueBinaryArray[blueBinaryArray.Length - indexOffset] = blueNewLSB;
        string modifiedBlue = new string(blueBinaryArray);

        // Return the modified RGBBinary struct with updated binary values
        return new RGBBinary(modifiedRed, modifiedGreen, modifiedBlue);
    }


}
