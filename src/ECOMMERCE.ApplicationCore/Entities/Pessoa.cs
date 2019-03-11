using System.Collections;
using System.Collections.Generic;

namespace SGREFRI.ApplicationCore.Entities
{
   public class Pessoa
    {
        public Pessoa()
        {

        }
        public int PessoaId { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //Chave estrangeira
        public int PessoaTipoId { get; set; }
        public PessoaTipo PessoaTipo { get; set; }

        public ICollection<Contato>  Contatos{ get; set; }

        public ICollection<Cliente> Clientes { get; set; }

        public ICollection<EnderecoPessoa> EnderecosPessoas { get; set; }

        public ICollection<Email> Emails { get; set; }

        public ICollection<ProfissaoPessoa> ProfissaoPessoa { get; set; }
    }
}
