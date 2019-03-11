using ECOMMERCE.ApplicationCore.Entities;
using SGREFRI.ApplicationCore.Entities;
using System.Linq;


namespace ECOMMERCE.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ECOMMERCEContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

    
           

           
        }
    }
}