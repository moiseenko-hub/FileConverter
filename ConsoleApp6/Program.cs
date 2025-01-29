using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        JsonToXmlConverter.Convert<Squad>("/Users/andrejmoiseenko/RiderProjects/ConsoleApp6/ConsoleApp6/bin/Debug/net9.0/superhero");
        //XmlToJsonConverter.Convert<User>("../result.xml","app");

        foreach (var item in Directory.GetFiles(Environment.CurrentDirectory))
        {
            Console.WriteLine(item);
        }
    }
}