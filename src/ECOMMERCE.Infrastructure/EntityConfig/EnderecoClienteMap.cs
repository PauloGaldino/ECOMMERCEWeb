using ECOMMERCE.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECOMMERCE.Infrastructure.EntityConfig
{
    public class EnderecoClienteMap : IEntityTypeConfiguration<EnderecoCliente>
    {
        public void Configure(EntityTypeBuilder<EnderecoCliente> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
               .HasOne(pc => pc.Cliente)
               .WithMany(e => e.EnderecosClientes)
               .HasForeignKey(e => e.ClienteId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(pc => pc.Endereco)
                    .WithMany(e => e.EnderecosClientes)
                    .HasForeignKey(e => e.EnderecoId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
