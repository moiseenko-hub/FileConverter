using System.Text.Json.Serialization;

namespace ConsoleApp6;

public class Member
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("age")]
    public int Age { get; set; }
    
    [JsonPropertyName("secretIdentity")]
    public string SecretIdentity { get; set; }
    
    [JsonPropertyName("powers")]
    public List<string> Powers { get; set; }
}