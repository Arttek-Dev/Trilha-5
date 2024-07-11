using ComexAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace ComexAPI.Data;

public class ProdutoContext(DbContextOptions<ProdutoContext> options) : DbContext(options)
{
    public DbSet<Produto> Produtos { get; set; }
}
