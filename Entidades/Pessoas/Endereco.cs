namespace Entidades.Pessoas
{
    public class Endereco
    {
        public int Codigo { get; set; }
        public int CodigoCliente { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public bool IsEnderecoPadrao { get; set; }
    }
}
