namespace APIDrugovich.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public DateOnly DataFundacao { get; set; }
    }
}
