﻿using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Entities
{
    public class Endereco
    {
        public Endereco()
        {

        }

        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

      
        //Coleçoes
        public ICollection<EnderecoCliente> EnderecosClientes { get; set; }
    }
}
