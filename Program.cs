using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Encoder.Encode("My Very Secret and Hidden Message no one is allowed to ever see!");
        Decoder.Decode();
    }

}