﻿using System.Collections.Generic;

namespace SGREFRI.ApplicationCore.Entities
{
    public class Profissao
    {
        public Profissao()
        {

        }
        public int ProfissaoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string CBO { get; set; }

        public ICollection<ProfissaoPessoa> ProfissaoPessoa { get; set; }
    }
}
