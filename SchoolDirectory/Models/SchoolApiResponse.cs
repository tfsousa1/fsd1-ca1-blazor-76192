using System.Text.Json.Serialization;

namespace SchoolDirectory.Models;

/// <summary>
/// Represents the outer structure returned by the Edutots API.
/// </summary>
public class SchoolApiResponse
{
    [JsonPropertyName("value")]
    public List<School> Value { get; set; } = new();

    [JsonPropertyName("Count")]
    public int Count { get; set; }
}