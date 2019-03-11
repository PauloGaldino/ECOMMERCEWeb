
using Microsoft.EntityFrameworkCore;
using SGREFRI.ApplicationCore.Entities;
using SGREFRI.Infrastructure.EntityConfig;

namespace SGREFRI.Infrastructure.Data
{
    public class GeneralContext : DbContext
    {
        public GeneralContext(DbContextOptions<GeneralContext>options)
            :base(options)
        {

        }

        public DbSet<PessoaTipo> PessoaTipo { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fisica> PessoaFisica { get; set; }
        public DbSet<Juridica> Juridica { get; set; }
        public DbSet<Fisica> Fisica { get; set; }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EnderecoPessoa> EnderecosPessoas { get; set; }
        public DbSet<Email> Emails { get; set; }
        //public DbSet<EmailPessoa> EmailsPessoas { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TelefoneTipo> TelefoneTipo { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Profissao> Profissao { get; set; }
        public DbSet<ProfissaoPessoa> ProfissaoPessoa { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoTipo> ProdutoTipo { get; set; }

        public DbSet<Preco> Preco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");

            modelBuilder.Entity<PessoaTipo>().ToTable("PessoaTipo");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Fisica>().ToTable("Fisica");
            modelBuilder.Entity<Juridica>().ToTable("Juridica");

            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Email>().ToTable("Email");
           // modelBuilder.Entity<EmailPessoa>().ToTable("EmailPessoa");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<EnderecoPessoa>().ToTable("EnderecoPessoa");
            modelBuilder.Entity<Telefone>().ToTable("Telefone");
            modelBuilder.Entity<TelefoneTipo>().ToTable("TelefoneTipo");

            modelBuilder.Entity<Operacao>().ToTable("Operacao");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoPessoa>().ToTable("ProfissaoPessoa");

            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<ProdutoTipo>().ToTable("ProdutoTipo");

            modelBuilder.Entity<Preco>().ToTable("Preco");

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());

            modelBuilder.ApplyConfiguration(new PessoaTipoConfiguration());
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new FisicaConfiguration());
            modelBuilder.ApplyConfiguration(new JuridicaConfiguration());

            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoPessoaConfiguration());

            modelBuilder.ApplyConfiguration(new EmailConfiguration());
           // modelBuilder.ApplyConfiguration(new EmailPessoaConfiguration());

            modelBuilder.ApplyConfiguration(new TelefoneConfiguration());
            modelBuilder.ApplyConfiguration(new TelefoneTipoConfiguration());

            modelBuilder.ApplyConfiguration(new ProfissaoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfissaoPessoaConfiguration());

            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoTipoConfiguration());

            modelBuilder.ApplyConfiguration(new PrecoConfiguration());

        }
    }
}
