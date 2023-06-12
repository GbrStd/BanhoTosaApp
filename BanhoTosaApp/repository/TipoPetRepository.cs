using BanhoTosaApp.db;
using BanhoTosaApp.model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BanhoTosaApp.repository
{
    public class TipoPetRepository
    {

        public static void Insert(TipoPet entity)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string insert = "INSERT INTO TipoPet (Nome) VALUES (@Nome);";

            SqlCommand cmd = new SqlCommand(insert, conn);

            cmd.Parameters.AddWithValue("@Nome", entity.Nome);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static List<TipoPet> FindAll()
        {
            List<TipoPet> tipoPets = new List<TipoPet>();

            SqlConnection conn = AppSQLConnection.GetConnection();

            string select = "SELECT * FROM TipoPet;";

            SqlCommand cmd = new SqlCommand(select, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TipoPet tipoPet = new TipoPet();
                tipoPet.Id = dr.GetInt32(0);
                tipoPet.Nome = dr.GetString(1);
                tipoPets.Add(tipoPet);
            }

            conn.Close();

            return tipoPets;
        }

        public static void DeleteById(int id)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string delete = "DELETE FROM TipoPet WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(delete, conn);

            cmd.Parameters.AddWithValue("@Id", id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static void Update(TipoPet entity)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string update = "UPDATE TipoPet SET Nome = @Nome WHERE Id = @Id;";

            SqlCommand cmd = new SqlCommand(update, conn);

            cmd.Parameters.AddWithValue("@Nome", entity.Nome);
            cmd.Parameters.AddWithValue("@Id", entity.Id);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static TipoPet FindById(int id)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string select = "SELECT * FROM TipoPet WHERE Id = @Id;";
            
            SqlCommand cmd = new SqlCommand(select, conn);
            
            cmd.Parameters.AddWithValue("@Id", id);
            
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
            {
                conn.Close();
                return null;
            }

            TipoPet tipoPet = new TipoPet();
            tipoPet.Id = dr.GetInt32(0);
            tipoPet.Nome = dr.GetString(1);

            conn.Close();

            return tipoPet;
        }
    }
}
