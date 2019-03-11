using System;

namespace SGREFRI.ApplicationCore.Entities
{
    public class Produto
    {
        public Produto()
        {

        }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public string Lote { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }

        public int ProdutoTipoId { get; set; }
        public ProdutoTipo ProdutoTipo { get; set; }

        public Preco Preco { get; set; }





    }

}
