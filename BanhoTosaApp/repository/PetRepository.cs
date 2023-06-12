using BanhoTosaApp.db;
using BanhoTosaApp.model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BanhoTosaApp.repository
{
    public class PetRepository
    {

        public static void Insert(Pet pet)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string insert = "INSERT INTO Pet (Nome, Raca, Porte, TipoPetId, DonoId, DataNascimento) VALUES (@Nome, @Raca, @Porte, @TipoPetId, @DonoId, @DataNascimento);";

            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@Nome", pet.Nome);
            cmd.Parameters.AddWithValue("@Raca", pet.Raca);
            cmd.Parameters.AddWithValue("@Porte", pet.Porte);
            cmd.Parameters.AddWithValue("@TipoPetId", pet.TipoPet.Id);
            cmd.Parameters.AddWithValue("@DonoId", pet.Dono.Id);
            cmd.Parameters.AddWithValue("@DataNascimento", pet.DataNascimento);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<Pet> FindAll()
        {
            List<Pet> pets = new List<Pet>();

            SqlConnection conn = AppSQLConnection.GetConnection();

            string findAll = "SELECT p.Id, p.Nome, p.Raca, p.Porte, p.DataNascimento, d.Id AS DonoId, d.Nome AS DonoNome, d.CPF, d.Telefone, t.Id as TipoPetId, t.Nome AS TipoPetNome From Pet p INNER JOIN Pessoa d ON p.DonoId = d.Id INNER JOIN TipoPet t ON p.TipoPetId = t.Id;";

            SqlCommand cmd = new SqlCommand(findAll, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Pet pet = new Pet();
                pet.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                pet.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                pet.Raca = reader.GetString(reader.GetOrdinal("Raca"));
                pet.Porte = reader.GetString(reader.GetOrdinal("Porte"));
                TipoPet tipoPet = new TipoPet();
                tipoPet.Id = reader.GetInt32(reader.GetOrdinal("TipoPetId"));
                tipoPet.Nome = reader.GetString(reader.GetOrdinal("TipoPetNome"));
                pet.TipoPet = tipoPet;
                Pessoa dono = new Pessoa();
                dono.Id = reader.GetInt32(reader.GetOrdinal("DonoId"));
                dono.Nome = reader.GetString(reader.GetOrdinal("DonoNome"));
                pet.Dono = dono;
                pet.DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento"));
                pets.Add(pet);
            }

            conn.Close();

            return pets;
        }

        public static void DeleteById(int id)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string delete = "DELETE FROM Pet WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(delete, conn);

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void Update(Pet pet)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string update = "UPDATE Pet SET Nome = @Nome, Raca = @Raca, Porte = @Porte, TipoPetId = @TipoPetId, DonoId = @DonoId, DataNascimento = @DataNascimento WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(update, conn);

            cmd.Parameters.AddWithValue("@Id", pet.Id);
            cmd.Parameters.AddWithValue("@Nome", pet.Nome);
            cmd.Parameters.AddWithValue("@Raca", pet.Raca);
            cmd.Parameters.AddWithValue("@Porte", pet.Porte);
            cmd.Parameters.AddWithValue("@TipoPetId", pet.TipoPet.Id);
            cmd.Parameters.AddWithValue("@DonoId", pet.Dono.Id);
            cmd.Parameters.AddWithValue("@DataNascimento", pet.DataNascimento);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
