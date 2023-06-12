using BanhoTosaApp.db;
using BanhoTosaApp.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BanhoTosaApp.repository
{
    public class PessoaRepository
    {
        public static bool Insert(Pessoa pessoa)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string insertPessoa = "INSERT INTO Pessoa (Nome, CPF, Telefone) OUTPUT inserted.Id VALUES (@Nome, @CPF, @Telefone);";

            SqlCommand cmdPessoa = new SqlCommand(insertPessoa, conn);

            cmdPessoa.Parameters.AddWithValue("@Nome", pessoa.Nome);
            cmdPessoa.Parameters.AddWithValue("@CPF", pessoa.CPF);
            cmdPessoa.Parameters.AddWithValue("@Telefone", pessoa.Telefone);

            int pessoaId = Int32.Parse(cmdPessoa.ExecuteScalar().ToString());

            string insertEndereco = "INSERT INTO Endereco (Cidade, Rua, Numero, Bairro, PessoaId) VALUES (@Cidade, @Rua, @Numero, @Bairro, @PessoaId);";

            SqlCommand cmdEndereco = new SqlCommand(insertEndereco, conn);

            cmdEndereco.Parameters.AddWithValue("@Cidade", pessoa.Endereco.Cidade);
            cmdEndereco.Parameters.AddWithValue("@Rua", pessoa.Endereco.Rua);
            cmdEndereco.Parameters.AddWithValue("@Numero", pessoa.Endereco.Numero);
            cmdEndereco.Parameters.AddWithValue("@Bairro", pessoa.Endereco.Bairro);
            cmdEndereco.Parameters.AddWithValue("@PessoaId", pessoaId);

            cmdEndereco.ExecuteNonQuery();

            conn.Close();

            return true;
        }

        public static List<Pessoa> FindAll()
        {

            SqlConnection conn = AppSQLConnection.GetConnection();

            List<Pessoa> pessoas = new List<Pessoa>();

            string findAll = @"SELECT p.id,
                                      p.nome,
                                      p.cpf,
                                      p.telefone,
                                      e.id AS EnderecoId,
                                      e.cidade,
                                      e.rua,
                                      e.numero,
                                      e.bairro
                                FROM  pessoa p
                                      INNER JOIN endereco e
                                              ON e.pessoaid = p.id;";

            SqlCommand cmdFindAll = new SqlCommand(findAll, conn);

            SqlDataReader sdr = cmdFindAll.ExecuteReader();

            while (sdr.Read())
            {
                Pessoa p = new Pessoa();
                Endereco e = new Endereco();

                p.Id = Convert.ToInt32(sdr["Id"]);
                p.Nome = sdr["Nome"].ToString().TrimEnd();
                p.CPF = sdr["CPF"].ToString().TrimEnd();
                p.Telefone = sdr["Telefone"].ToString().TrimEnd();

                e.Id = Convert.ToInt32(sdr["EnderecoId"]);
                e.Cidade = sdr["Cidade"].ToString().TrimEnd();
                e.Rua = sdr["Rua"].ToString().TrimEnd();
                e.Numero = Convert.ToInt32(sdr["Numero"]);
                e.Bairro = sdr["Bairro"].ToString().TrimEnd();

                p.Endereco = e;

                pessoas.Add(p);
            }

            conn.Close();

            return pessoas;
        }

        public static void DeleteById(int id)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string deleteEndereco = "DELETE FROM Endereco WHERE PessoaId = @Id;";

            SqlCommand cmdDeleteEndereco = new SqlCommand(deleteEndereco, conn);
            cmdDeleteEndereco.Parameters.AddWithValue("@Id", id);

            cmdDeleteEndereco.ExecuteNonQuery();

            string deletePessoa = "DELETE FROM Pessoa WHERE Id = @Id;";

            SqlCommand cmdDeletePessoa = new SqlCommand(deletePessoa, conn);
            cmdDeletePessoa.Parameters.AddWithValue("@Id", id);

            cmdDeletePessoa.ExecuteNonQuery();

            conn.Close();
        }

        public static void Update(Pessoa p)
        {
            SqlConnection conn = AppSQLConnection.GetConnection();

            string updatePessoa = @"UPDATE Pessoa
                                    SET Nome = @Nome,
                                        CPF = @CPF,
                                        Telefone = @Telefone
                                    WHERE Id = @Id;";

            SqlCommand cmdUpdatePessoa = new SqlCommand(updatePessoa, conn);

            cmdUpdatePessoa.Parameters.AddWithValue("@Nome", p.Nome);
            cmdUpdatePessoa.Parameters.AddWithValue("@CPF", p.CPF);
            cmdUpdatePessoa.Parameters.AddWithValue("@Telefone", p.Telefone);
            cmdUpdatePessoa.Parameters.AddWithValue("@Id", p.Id);

            cmdUpdatePessoa.ExecuteNonQuery();

            string updateEndereco = @"UPDATE Endereco
                                      SET Cidade = @Cidade,
                                          Rua = @Rua,
                                          Numero = @Numero,
                                          Bairro = @Bairro
                                      WHERE PessoaId = @Id;";

            SqlCommand cmdUpdateEndereco = new SqlCommand(updateEndereco, conn);

            cmdUpdateEndereco.Parameters.AddWithValue("@Cidade", p.Endereco.Cidade);
            cmdUpdateEndereco.Parameters.AddWithValue("@Rua", p.Endereco.Rua);
            cmdUpdateEndereco.Parameters.AddWithValue("@Numero", p.Endereco.Numero);
            cmdUpdateEndereco.Parameters.AddWithValue("@Bairro", p.Endereco.Bairro);
            cmdUpdateEndereco.Parameters.AddWithValue("@Id", p.Id);

            cmdUpdateEndereco.ExecuteNonQuery();

            conn.Close();
        }

        public static Pessoa FindById(int id)
        {

            return null;

        }
    }
}
