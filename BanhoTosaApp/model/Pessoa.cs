namespace BanhoTosaApp.model
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public Endereco Endereco { get; set; }

        public string Telefone { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string nome, string cPF, Endereco endereco, string telefone)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"{Id}: {Nome}";
        }

    }
}
