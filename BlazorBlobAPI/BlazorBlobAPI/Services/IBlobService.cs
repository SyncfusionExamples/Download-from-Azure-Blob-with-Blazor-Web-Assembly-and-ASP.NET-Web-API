using BlazorBlobAPI.Models.Dtos;

namespace BlazorBlobAPI.Services;

public interface IBlobService
{
    Task<List<BlobDto>> GetBlobFiles();

    Task<ContentDto> GetBlobFile(string name);
}