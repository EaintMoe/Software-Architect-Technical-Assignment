using BlazorImportFile.dbcontext;
using BlazorImportFile.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorImportFile.Services
{
    public class ImportService : IImportService
    {
        public async Task AddNewImport(Import import)
        {
           using(var context = new ApplicationDbContext())
            {
                await context.imports.AddAsync(import);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Import>> GetAllImport()
        {
            using (var context = new ApplicationDbContext())
            {
                return await context.imports.ToListAsync();
            }
        }
    }
}
