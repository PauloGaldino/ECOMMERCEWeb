using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGREFRI.ApplicationCore.Entities;

namespace SGREFRI.Infrastructure.EntityConfig
{
    public class EnderecoPessoaConfiguration : IEntityTypeConfiguration<EnderecoPessoa>
    {
        public void Configure(EntityTypeBuilder<EnderecoPessoa> builder)
        {
           

            builder
                .HasOne(ep => ep.Pessoa)
                .WithMany(ep => ep.EnderecosPessoas)
                .HasForeignKey(ep => ep.PessoaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ep => ep.Endereco)
                .WithMany(ep => ep.EnderecosPessoas)
                .HasForeignKey(ep => ep.EnderecoId)
                .OnDelete(DeleteBehavior.Restrict);

          
        }
    }
}
