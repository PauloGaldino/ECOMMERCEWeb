using ECOMMERCE.ApplicationCore.Entities;
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

            var clientes = new Cliente[]
            {
                new Cliente {

                    Nome = "Fulano",
                    Sobrenome= "Silva",
                    CPF = "76664173735",
                    Ativo=true

                },

                 new Cliente {
                    Nome = "Beltrano",
                    Sobrenome="Silva",
                    CPF = "54589486377",
                    Ativo=false
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato {
                    Nome = "Contato 1",
                    Telefone = "99999999",
                    Email = "emailcontato1@teste.com",
                    Cliente = clientes[0]
                },

                new Contato {
                    Nome = "Contato 2",
                    Telefone = "333333",
                    Email = "emailcontato2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}