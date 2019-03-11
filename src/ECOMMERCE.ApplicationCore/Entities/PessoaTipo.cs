using System.Collections.Generic;

namespace SGREFRI.ApplicationCore.Entities
{
    public class PessoaTipo
    {
        public PessoaTipo()
        {

        }
        public int PessoaTipoId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Pessoa> Pessoas { get; set; }




    }
}
