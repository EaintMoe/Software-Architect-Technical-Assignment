using BlazorImportFile.Models;
namespace BlazorImportFile.Services
{
    public interface IImportService
    {
        Task AddNewImport(Import import);
        Task<List<Import>> GetAllImport();
    }
}
