namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco == 0)
                AdicionarCritica("O produto esta de graça!");
            if (!string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto esta vazio");
        }
    }
}
