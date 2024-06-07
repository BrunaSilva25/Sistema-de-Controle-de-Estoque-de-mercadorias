using System;

namespace APITeste.Models
{
    public class MovimentacaoEstoque
    {
        public int ID { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public string TipoMovimentacao { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataMovimentacao { get; set; }
    }
}
