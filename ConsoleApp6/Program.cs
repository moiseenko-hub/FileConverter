using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
        //JsonToXmlConverter.Convert<User>("app.json", "../result.xml");
        XmlToJsonConverter.Convert<User>("../result.xml","app.json");
    }
}