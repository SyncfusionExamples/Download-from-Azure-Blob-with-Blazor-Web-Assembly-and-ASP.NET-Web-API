using BlazorBlobAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazorBlobAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilesController : Controller
{

    private readonly IBlobService _blobService;
    
    public FilesController(IBlobService blobService)
    {
        _blobService = blobService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result =  await _blobService.GetBlobFiles();

        return Ok(result);
    }
    
    [HttpGet("{name}")]
    public async Task<IActionResult> Get(string name)
    {
        var result =  await _blobService.GetBlobFile(name);

        if (result == null)
            return BadRequest();
        
        return File(result.Content,result.ContentType, result.Name);
    }
    
}