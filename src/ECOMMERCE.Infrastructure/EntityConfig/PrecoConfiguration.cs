﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class PrecoConfiguration : IEntityTypeConfiguration<Preco>
    {
        public void Configure(EntityTypeBuilder<Preco> builder)
        {
            builder.HasKey(pr => pr.ProdutoId);

            builder.Property(pr => pr.ProdutoId).ValueGeneratedNever();

            builder
                .HasOne(pr => pr.Produto)
                .WithOne(pr => pr.Preco)
                .HasForeignKey<Produto>(pr => pr.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(pr => pr.Precos)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}
