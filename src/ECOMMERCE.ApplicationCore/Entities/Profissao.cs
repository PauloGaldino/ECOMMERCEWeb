using System.Collections.Generic;

namespace ECOMMERCE.ApplicationCore.Entities
{
    public class Profissao
    {
        public Profissao()
        {

        }
        public int ProfissaoId { get; set; }
        public string ProfissaoNome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }

        //Coleçoes
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }

    }
}
