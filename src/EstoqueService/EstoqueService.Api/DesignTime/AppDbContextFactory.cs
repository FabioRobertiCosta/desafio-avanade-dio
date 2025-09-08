using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using EstoqueService.Api.Data;

namespace EstoqueService.Api.DesignTime
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=EstoqueDB;User=sa;Password=SuaSenhaSegura!;Encrypt=False;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}