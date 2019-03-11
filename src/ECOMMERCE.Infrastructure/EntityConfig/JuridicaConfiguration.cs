﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class JuridicaConfiguration : IEntityTypeConfiguration<Juridica>
    {
        public void Configure(EntityTypeBuilder<Juridica> builder)
        {
            builder.HasKey(j => j.JuridicaId);

            builder.Property(j => j.NomeFantasia)
                .HasColumnType("varchar (200)")
                .IsRequired();

            builder.Property(j => j.RazaoSocial)
                .HasColumnType("Varchar (200)")
                .IsRequired();

            builder.Property(j => j.Cnpj)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(j => j.InscricaoEstadual)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(j => j.DataFundacao)
                .IsRequired();
            
        }
    }
}
