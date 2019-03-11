using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class EmailConfiguration : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.HasKey(em => em.EmailId);

            builder
                .HasOne(em => em.Pessoa)
                .WithMany(em => em.Emails)
                .HasForeignKey(em => em.PessoaId)
                .HasPrincipalKey(em => em.PessoaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(em => em.EnderecoEmail)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
