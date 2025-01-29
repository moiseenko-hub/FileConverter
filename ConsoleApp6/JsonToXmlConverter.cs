using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp6;

public abstract class JsonToXmlConverter() : IFileConverter
{
    public static void Convert<T>(string inputPath)
    {
        foreach (var item in GetTargetFileName(inputPath))
        {
            var jsonString = File.ReadAllText(item);
            var objT = JsonSerializer.Deserialize<T>(jsonString);
            using StreamWriter sw = new StreamWriter($"{item}{Guid.NewGuid().ToString()}.xml");
            new XmlSerializer(typeof(T)).Serialize(sw,objT);
        }
    }

    private static IEnumerable<string> GetTargetFileName(string inputPath)
    {
        var files = Directory.GetFiles(inputPath);
        foreach (var item in files)
        {
            if (Path.GetExtension(item) == ".json")
            {
                yield return item;
            }
        }
    }
    
}