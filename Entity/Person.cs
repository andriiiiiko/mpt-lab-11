using System.Text.Json.Serialization;

namespace mpt_lab_11.Entity;

public class Person
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("first_name")]
    public required string FirstName { get; set; }
    
    [JsonPropertyName("last_name")]
    public required string LastName { get; set; }
    
    [JsonPropertyName("email")]
    public required string Email { get; set; }
    
    [JsonPropertyName("gender")]
    public required string Gender { get; set; }

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, " +
               $"{nameof(Email)}: {Email}, {nameof(Gender)}: {Gender}";
    }
}    