using Microsoft.EntityFrameworkCore;
using SGREFRI.ApplicationCore.Entities;
using SGREFRI.Infrastructure.EntityConfig;

namespace SGREFRI.Infrastructure.Data
{
    public class PessoaContext :DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext>options)
            :base(options)
        {

        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        

            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}
