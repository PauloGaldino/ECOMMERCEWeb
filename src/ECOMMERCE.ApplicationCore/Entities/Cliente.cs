﻿using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Entities
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public ICollection<Contato> Contatos { get; set; }
    }
}
