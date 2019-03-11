using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class PessoaTipoConfiguration : IEntityTypeConfiguration<PessoaTipo>
    {
        public void Configure(EntityTypeBuilder<PessoaTipo> builder)
        {
            builder.HasKey(pt => pt.PessoaTipoId);

           

            builder.Property(pt => pt.Descricao)
                .HasColumnType("varchar (10)")
                .IsRequired();
        }
    }
}
