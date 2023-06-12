using System;

namespace BanhoTosaApp.model
{
    public class Pet
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public string Porte { get; set; }
        public TipoPet TipoPet { get; set; }
        public Pessoa Dono { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pet()
        {
        }

        public Pet(int id, string nome, string raca, string porte, TipoPet tipoPet, Pessoa dono, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Raca = raca;
            Porte = porte;
            TipoPet = tipoPet;
            Dono = dono;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

    }
}
