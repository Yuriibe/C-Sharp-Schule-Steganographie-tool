using System;
using System.Drawing;
using System.Text;
using System.IO;

public class Decoder
{
    public static string Decode(Bitmap image)
    {
   
        StringBuilder binaryString = new StringBuilder();

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                 // Retrieve the RGB binary values for the pixel at coordinates (x, y)
                RGBBinary binaryValues = GetPixelRGBBinary(image, x, y);
                // Append the Least Significant Bit (LSB) to the binary string
                binaryString.Append(GetLSB(binaryValues.Red));
                binaryString.Append(GetLSB(binaryValues.Green));
                binaryString.Append(GetLSB(binaryValues.Blue));

            }
        }
        // Convert the binary string representation into a readable text message.
        string message = BinaryToText(binaryString.ToString());

        // Console.WriteLine("Decoded message: " + message);
        string filePath = "output.txt";
        string textToWrite = message;

        // Write the text to the file
        File.WriteAllText(filePath, textToWrite);

        Console.WriteLine($"Text successfully written to {filePath}");
        return textToWrite;
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
    static string BinaryToText(string binary)
    {
        StringBuilder text = new StringBuilder();

        // Process the binary string in chunks of 8 bits
        for (int i = 0; i < binary.Length; i += 8)
        {
            if (i + 8 <= binary.Length)
            {
                // Get 8-bit chunks
                string byteString = binary.Substring(i, 8);

                // Convert binary to integer
                int asciiValue = Convert.ToInt32(byteString, 2);

                // Convert the integer to a character
                text.Append((char)asciiValue);
            }
        }

        return text.ToString();
    }

    static char GetLSB(string binaryValue)
    {
        // Returns The LSB which is simply the last character of the binary string 
        return binaryValue[binaryValue.Length - 1];
    }
}