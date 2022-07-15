using BlazorBlobDemo.Models;

namespace BlazorBlobDemo.Services;

public interface IFileService
{
    Task<List<BlobDto>> GetFiles();
    
    Task<ContentDto> DownloadFile(string name);
}