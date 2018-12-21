using ECOMMERCE.ApplicationCore.Entities;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
        }
    }
}
