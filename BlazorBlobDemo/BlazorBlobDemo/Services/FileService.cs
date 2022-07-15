using System.Net.Http.Headers;
using System.Text.Json;
using BlazorBlobDemo.Models;

namespace BlazorBlobDemo.Services;

public class FileService : IFileService
{
    private readonly HttpClient _client;
    private const string _baseUrl = "https://localhost:7174/api/";
    
    public FileService()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }
    
    public async Task<List<BlobDto>> GetFiles()
    {
        var response = await _client.GetAsync(_baseUrl+"files");
        var result = response.Content.ReadAsStringAsync().Result;
        var blobList = JsonSerializer.Deserialize<List<BlobDto>>(result);

        return blobList;
    }

    public async Task<ContentDto> DownloadFile(string name)
    {
        var response = await _client.GetByteArrayAsync(_baseUrl+"files/"+name);

        var content = new ContentDto()
        {
            Content = response,
            Name = name
        };
        
        return content;
    }
}