namespace GestaoEstoque.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public int CategoriaId { get; set; }

        //Propriedade de navegação
        public Categoria Categoria { get; set; }
        public ICollection<Movimentacao> Movimentacoes { get; set; }


    }
}