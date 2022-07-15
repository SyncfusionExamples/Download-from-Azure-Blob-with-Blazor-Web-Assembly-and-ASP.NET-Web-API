namespace BlazorBlobAPI.Models.Dtos;

public class ContentDto
{
    public Stream Content { get; set; }
    public string Name { get; set; }
    public string ContentType { get; set; }
}