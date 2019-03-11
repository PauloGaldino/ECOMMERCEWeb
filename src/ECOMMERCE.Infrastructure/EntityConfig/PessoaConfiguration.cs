using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.PessoaId);

            builder
                .HasOne(p => p.PessoaTipo)
                .WithMany(p => p.Pessoas)
                .HasForeignKey(p => p.PessoaTipoId)
                .HasPrincipalKey(p => p.PessoaTipoId)
                .OnDelete(DeleteBehavior.Restrict);
           

            builder.Property(p => p.Nome)
                .HasColumnType("varchar (100)")
                .IsRequired();

            builder.Property(p => p.Sobrenome)
                .HasColumnType("varchar(50)")
                .IsRequired();

        }
    }
}
 