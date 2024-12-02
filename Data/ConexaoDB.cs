using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_agenda_telefonica.Data
{
    internal static class ConexaoDB
    {
        public static MySqlConnection Conexao()
        {
            // String contendo as credenciais para a conexão SQL
            string comando = "Server=localhost;Database=db_agenda;User ID=root;Password=root;";

            // Instanciando a conexao
            MySqlConnection connection = new MySqlConnection(comando);

            return connection;
        }

        public static MySqlConnection? Conexao(string usuario, string senha)
        {
            string comando = $"Server=localhost;Database=db_agenda;User ID={usuario};Password={senha};";

            MySqlConnection connection = new MySqlConnection(comando);

            try
            {
                // Validando a conexão
                connection.Open();

                return connection;
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return null;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
