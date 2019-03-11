using ECOMMERCE.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using SGREFRI.ApplicationCore.Entities;

namespace ECOMMERCE.Infrastructure.Data
{
    public class ECOMMERCEContext : DbContext
    {
        public ECOMMERCEContext(DbContextOptions<ECOMMERCEContext> options)
            : base(options)
        {

        }
        public DbSet<PessoaTipo> PessoaTipo { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Profissao> Rrofissoes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaTipo>().ToTable("PessoaTipo");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");
            modelBuilder.Entity<EnderecoCliente>().ToTable("EnderecoCliente");

         

        }
    }
}
