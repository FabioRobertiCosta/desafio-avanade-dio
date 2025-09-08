using Microsoft.EntityFrameworkCore;
using EstoqueService.Api.Models; // Você precisará criar a classe 'Produto' no próximo passo.

namespace EstoqueService.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}