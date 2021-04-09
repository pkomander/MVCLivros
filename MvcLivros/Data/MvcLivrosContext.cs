using Microsoft.EntityFrameworkCore;
using MvcLivros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
