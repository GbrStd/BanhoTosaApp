namespace BanhoTosaApp.model
{
    public class TipoPet
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public TipoPet()
        {
        }

        public TipoPet(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
