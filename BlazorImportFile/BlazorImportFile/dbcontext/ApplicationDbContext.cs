using Microsoft.EntityFrameworkCore;
using BlazorImportFile.Models;

namespace BlazorImportFile.dbcontext
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=DESKTOP-3AULBMF;Database=import_db;Trusted_Connection=true;");

        public DbSet<Import> imports { get; set; }
    }
}
