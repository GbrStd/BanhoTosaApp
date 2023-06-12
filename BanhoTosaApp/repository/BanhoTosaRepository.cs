using BanhoTosaApp.db;
using BanhoTosaApp.model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BanhoTosaApp.repository
{
    public class BanhoTosaRepository
    {
        public static void Insert(BanhoTosa banhoTosa)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string insert = "INSERT INTO BanhoTosa (PetId, Data, Tosar, Observacao, Valor) VALUES (@PetId, @Data, @Tosar, @Observacao, @Valor);";

            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@PetId", banhoTosa.Pet.Id);
            cmd.Parameters.AddWithValue("@Data", banhoTosa.Data);
            cmd.Parameters.AddWithValue("@Tosar", banhoTosa.Tosar);
            cmd.Parameters.AddWithValue("@Observacao", banhoTosa.Observacao);
            cmd.Parameters.AddWithValue("@Valor", banhoTosa.Valor);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<BanhoTosa> FindAll()
        {
            List<BanhoTosa> banhoTosas = new List<BanhoTosa>();

            SqlConnection conn = AppSQLConnection.GetConnection();

            string select = "SELECT b.Id, b.PetId, b.Data, b.Tosar, b.Observacao, b.Valor, p.Nome, p.TipoPetId, p.DonoId FROM BanhoTosa b INNER JOIN Pet p ON b.PetId = p.Id;";

            SqlCommand cmd = new SqlCommand(select, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                BanhoTosa bt = new BanhoTosa();
                Pet p = new Pet();
                TipoPet tp = new TipoPet();
                Pessoa dono = new Pessoa();

                bt.Id = dr.GetInt32(0);
                p.Id = dr.GetInt32(1);
                bt.Data = dr.GetDateTime(2);
                bt.Tosar = dr.GetBoolean(3);
                bt.Observacao = dr.GetString(4);
                bt.Valor = dr.GetDouble(5);

                p.Nome = dr.GetString(6);
                tp.Id = dr.GetInt32(7);
                dono.Id = dr.GetInt32(8);

                p.TipoPet = tp;
                p.Dono = dono;
                bt.Pet = p;

                banhoTosas.Add(bt);
            }

            conn.Close();

            return banhoTosas;
        }

        public static void DeleteById(int id)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string delete = "DELETE FROM BanhoTosa WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(delete, conn);

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void Update(BanhoTosa banhoTosa)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string update = "UPDATE BanhoTosa SET PetId = @PetId, Data = @Data, Tosar = @Tosar, Observacao = @Observacao, Valor = @Valor WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(update, conn);

            cmd.Parameters.AddWithValue("@PetId", banhoTosa.Pet.Id);
            cmd.Parameters.AddWithValue("@Data", banhoTosa.Data);
            cmd.Parameters.AddWithValue("@Tosar", banhoTosa.Tosar);
            cmd.Parameters.AddWithValue("@Observacao", banhoTosa.Observacao);
            cmd.Parameters.AddWithValue("@Valor", banhoTosa.Valor);
            cmd.Parameters.AddWithValue("@Id", banhoTosa.Id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
