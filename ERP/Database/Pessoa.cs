using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pessoa
    {

        public int Salvar(string nome, string cpf, string telefone, string email)
        {
            int id = 0;
            var connString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "insert into Pessoas(nome,cpf,telefone, email) values(@nome,@cpf,@telefone,@email)SELECT SCOPE_IDENTITY()"; 
                SqlCommand cmd = new SqlCommand(sql, conn);
                              
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@email", email);
               try
                {
                    conn.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return (int)id;
        }

    }
}
