using System.Collections.Generic;

namespace SGREFRI.ApplicationCore.Entities
{
   public class Email
    {
        public Email()
        {

        }
        public int EmailId { get; set; }

        public string EnderecoEmail { get; set; }

        public int PessoaId { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
