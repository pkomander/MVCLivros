using Microsoft.EntityFrameworkCore;
using MvcLivros.Models;

namespace MvcLivros.Data
{
    public class MvcLivrosContext : DbContext
    {
        public MvcLivrosContext(DbContextOptions<MvcLivrosContext> options)
           : base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }
    }
}
