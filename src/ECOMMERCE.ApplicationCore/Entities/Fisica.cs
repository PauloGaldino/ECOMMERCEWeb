using System;

namespace SGREFRI.ApplicationCore.Entities
{
    public class Fisica
    {
        public Fisica()
        {

        }
        public int FisicaId { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        //Chave estrangeria
        public int PessoaId { get; set; }

        //Propriedade de navegação
        public Pessoa Pessoa { get; set; }
    }
}
