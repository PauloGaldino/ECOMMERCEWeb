using ECOMMERCE.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECOMMERCE.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
           

           builder.Property(e => e.Logradouro)
              .HasColumnType("varchar (200)")
              .IsRequired();

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar (100)")
                .IsRequired();

            builder.Property(e => e.CEP)
                .HasColumnType("varchar (15)")
                .IsRequired();

            builder.Property(e => e.Bairro)
               .HasColumnType("varchar (200)")
               .IsRequired();

            builder.Property(e => e.Cidade)
              .HasColumnType("varchar (200)")
              .IsRequired();

            builder.Property(e => e.Estado)
              .HasColumnType("char (2)")
              .IsRequired();

        }
    }
}
