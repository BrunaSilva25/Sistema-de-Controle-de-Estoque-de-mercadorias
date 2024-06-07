namespace APITeste.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
