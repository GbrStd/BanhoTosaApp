using System;

namespace BanhoTosaApp.model
{
    public class BanhoTosa
    {
        public int Id { get; set; }
        public Pet Pet { get; set; }
        public DateTime Data { get; set; }
        public bool Tosar { get; set; }
        public string Observacao { get; set; }
        public double Valor { get; set; }

        public BanhoTosa()
        {
        }

        public BanhoTosa(int id, Pet pet, DateTime data, bool tosar, string observacao, double valor)
        {
            Id = id;
            Pet = pet;
            Data = data;
            Tosar = tosar;
            Observacao = observacao;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Pet.Nome} - {Data}";
        }
    }
}
