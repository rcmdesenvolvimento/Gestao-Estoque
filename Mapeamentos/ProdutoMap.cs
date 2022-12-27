using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEstoque.Mapeamentos
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ProdutoId);
            builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.Preco).IsRequired();

            // Relacionamentos
            builder.HasOne(p => p.Categoria).WithMany(p => p.Produtos).HasForeignKey(p => p.CategoriaId).IsRequired();
            builder.HasMany(p => p.Movimentacoes).WithOne(p => p.Produto);

            builder.ToTable("Produtos");
        }
    }
}