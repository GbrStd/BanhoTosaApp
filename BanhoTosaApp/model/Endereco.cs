namespace BanhoTosaApp.model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string cidade, string rua, int numero, string bairro)
        {
            Id = id;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
        }

        public override string ToString()
        {
            return $"Cidade: {Cidade}, Rua: {Rua}, Número: {Numero}, Bairro: {Bairro}";
        }
    }
}
