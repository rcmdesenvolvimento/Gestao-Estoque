using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEstoque.Mapeamentos
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(m => m.MovimrntacaoId);
            builder.Property(m => m.Descricao).HasMaxLength(100).IsRequired();
            builder.Property(m => m.DataMovimentacao).IsRequired();

            builder.HasOne(m => m.Produto).WithMany(m => m.Movimentacoes).HasForeignKey(m => m.ProdutoId).IsRequired();

            builder.ToTable("Movimentacoes");
        }
    }
}