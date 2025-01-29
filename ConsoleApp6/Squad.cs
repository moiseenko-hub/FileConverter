using System.Text.Json.Serialization;

namespace ConsoleApp6;

public class Squad
{
    [JsonPropertyName("squadName")]
    public string SquadName { get; set; }
    
    [JsonPropertyName("homeTown")]
    public string HomeTowm { get; set; }
    
    [JsonPropertyName("formed")]
    public int Formed { get; set; }
    
    [JsonPropertyName("secretBase")]
    public string SecretBase { get; set; }
    
    [JsonPropertyName("active")]
    public bool Active { get; set; }
    
    [JsonPropertyName("members")]
    public List<Member> Members { get; set; }
}