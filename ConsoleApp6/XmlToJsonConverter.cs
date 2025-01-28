using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp6;

public class XmlToJsonConverter : IFileConverter
{
    public static void Convert<T>(string inputPath, string outputPath)
    {
        var xmlSerializer = new XmlSerializer(typeof(T));
        using Stream reader = new FileStream(inputPath, FileMode.Open);
        var result = (T)xmlSerializer.Deserialize(reader)!;
        File.WriteAllText(outputPath, JsonSerializer.Serialize(result));
    }
}