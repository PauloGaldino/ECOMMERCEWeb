﻿namespace SGREFRI.ApplicationCore.Entities
{
    public class ProdutoTipo
    {
        public ProdutoTipo()
        {

        }
        public int ProdutoTipoId { get; set; }
        public string Descricao { get; set; }

        public Produto Produto { get; set; }
    }
}
