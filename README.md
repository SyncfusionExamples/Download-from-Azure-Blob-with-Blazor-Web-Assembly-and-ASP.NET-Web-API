# Download from Azure Blob with Blazor WebAssembly and ASP.NET Web API

## Overview

This sample demonstrates how to retrieve file information from Azure Blob Storage through an ASP.NET Web API and present the results in a Blazor WebAssembly application. The UI displays available blob items as cards and allows users to download files directly from the browser by selecting an item.

The sample uses Syncfusion [Blazor Card](https://www.syncfusion.com/blazor-components/blazor-card) to render blob content, a custom service layer for API communication, and JavaScriptsave downloaded files on the client. This approach provides a practical pattern for integrating Azure Blob Storage with modern Blazor applications.

## Key Features

- Uses ASP.NET Web API endpoints in `FilesController` to expose Azure Blob Storage content.
- Retrieves Azure Blob metadata through `GetBlobFiles()` and returns a collection of `BlobDto` objects.
- Downloads individual blob content through `GetBlobFile(string name)` and returns files using the ASP.NET Core `File()` response.
- Integrates Azure Storage SDK (`BlobContainerClient` and `BlobClient`) to communicate with Azure Blob Storage.
- Enumerates blobs asynchronously using `GetBlobsAsync()` and constructs downloadable file metadata.
- Generates public blob URLs for image preview using the container URI and blob name.
- Uses the `IBlobService` abstraction to separate storage operations from controller logic.
- Displays Azure Blob images using the Syncfusion `SfCard` component and `CardImage` section.
- Retrieves blob metadata from the Web API through `IFileService.GetFiles()`.
- Downloads file content from the Web API through `IFileService.DownloadFile(string name)`.
- Uses `HttpClient` with JSON responses to communicate between the Blazor WebAssembly client and ASP.NET Web API.
- Loads blob data during `OnInitializedAsync()` to display available files when the page is rendered.
- Uses `IJSRuntime.InvokeAsync<IJSObjectReference>()` to dynamically import a JavaScript module.
- Uses JavaScript interop to save downloaded files directly in the browser.
- Transfers file content as byte arrays from the API to the Blazor WebAssembly client.
- Preserves original file names and content types during download operations.
- Uses dependency injection to register and consume `IBlobService` and `IFileService` implementations.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Open the solution file:

   `BlazorBlobDemo/BlazorBlobDemo.sln`

3. Restore NuGet packages.
4. Ensure the required API and client projects are included in the solution.
5. Build the solution.
6. Run the application using **Ctrl+F5**.
7. Verify that the ASP.NET Web API is running and accessible before using the download functionality.

**Visual Studio Code**

1. Open the repository folder.
2. Navigate to the solution/project directory.

```bash
cd BlazorBlobDemo
dotnet restore
dotnet run
```

3. Ensure the Web API project is running and available to the Blazor WebAssembly client.

## Project Structure

`BlazorBlobAPI/Controllers/FilesController.cs` - API controller that retrieves Azure Blob metadata and serves downloadable blob files.

`BlazorBlobAPI/Controllers/WeatherForecastController.cs` - Default ASP.NET Core sample controller included with the project template.

`BlazorBlobAPI/Services/IBlobService.cs` - Service contract for Azure Blob Storage operations.

`BlazorBlobAPI/Services/BlobService.cs` - Azure Blob Storage implementation using `BlobContainerClient` and `BlobClient` to retrieve blob metadata and content.

`BlazorBlobAPI/Models/Dtos/BlobDto.cs` - DTO containing blob name, file URL, and content type information.

`BlazorBlobAPI/Models/Dtos/ContentDto.cs` - DTO containing downloaded blob content, file name, and content type.

`BlazorBlobDemo/Pages/Index.razor` - Main sample page that loads Azure Blob files, displays images using Syncfusion Cards, and initiates file downloads.

`BlazorBlobDemo/Services/IFileService.cs` - Client-side service contract for communicating with the Web API.

`BlazorBlobDemo/Services/FileService.cs` - HttpClient-based implementation used to retrieve blob metadata and download files from the API.

`BlazorBlobDemo/Models/BlobDto.cs` - Client-side model representing Azure Blob metadata.

`BlazorBlobDemo/Models/ContentDto.cs` - Client-side model representing downloaded file content.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Documentation: https://blazor.syncfusion.com/documentation/card/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.