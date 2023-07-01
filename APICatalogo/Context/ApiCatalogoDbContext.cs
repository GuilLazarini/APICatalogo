using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class ApiCatalogoDbContext : DbContext
    {
        public ApiCatalogoDbContext(DbContextOptions<ApiCatalogoDbContext> options) : base (options) 
        {}
       
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
