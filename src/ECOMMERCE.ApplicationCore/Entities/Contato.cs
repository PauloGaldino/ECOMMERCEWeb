﻿namespace ECOMMERCE.ApplicationCore.Entities
{
    public class Contato
    {
        public Contato()
        {

        }

        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
