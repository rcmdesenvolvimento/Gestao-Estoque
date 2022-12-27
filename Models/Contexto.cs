using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoEstoque.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace GestaoEstoque.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Movimentacao> Movimentacacoes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());

        }
    }
}