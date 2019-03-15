using Microsoft.EntityFrameworkCore;

namespace ECOMMERCE.Infrastructure.Data
{
    public class DbCotextTeste :DbContext
    {
        public DbCotextTeste(DbContextOptions<DbCotextTeste>options)
            :base(options)
        {

        }
        
    }
}
