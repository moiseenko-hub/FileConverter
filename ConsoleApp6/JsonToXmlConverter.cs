using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp6;

public abstract class JsonToXmlConverter() : IFileConverter
{
    public static void Convert<T>(string inputPath, string outputPath)
    {
        var jsonString = File.ReadAllText(inputPath);
        var objT = JsonSerializer.Deserialize<T>(jsonString);
        using StreamWriter sw = new StreamWriter(outputPath);
        new XmlSerializer(typeof(T)).Serialize(sw,objT);
    }
    
}