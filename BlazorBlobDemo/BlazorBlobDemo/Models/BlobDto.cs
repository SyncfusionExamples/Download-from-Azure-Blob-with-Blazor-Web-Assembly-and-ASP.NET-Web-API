using System.Text.Json.Serialization;

namespace BlazorBlobDemo.Models;

public class BlobDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("fileUrl")]
    public string FileUrl { get; set; }
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; } 
}