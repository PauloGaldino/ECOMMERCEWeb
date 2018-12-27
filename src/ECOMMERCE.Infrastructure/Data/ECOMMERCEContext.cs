using ECOMMERCE.ApplicationCore.Entities;
using ECOMMERCE.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace ECOMMERCE.Infrastructure.Data
{
    public class ECOMMERCEContext : DbContext
    {
        public ECOMMERCEContext(DbContextOptions<ECOMMERCEContext> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Profissao> Rrofissoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");
            modelBuilder.Entity<EnderecoCliente>().ToTable("EnderecoCliente");

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EnderecoClienteMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoClienteMap());

        }
    }
}
