namespace GestaoEstoque.Models
{
    public class Movimentacao
    {
        public int MovimrntacaoId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public string Descricao { get; set; }
        public string DataMovimentacao { get; set; }

    

    }
}