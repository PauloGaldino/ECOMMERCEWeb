using System;
using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        //ativo e com 5 anos de cadastro
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

        //Coleções
        public ICollection<EnderecoCliente> EnderecosClientes { get; set; }
        public ICollection<Contato> Contatos { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }


    }
}
