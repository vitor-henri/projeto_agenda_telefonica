using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_agenda_telefonica.Controllers
{
    internal class UserController
    {
        public bool CriarUsuario(string nome, string usuario, string telefone, string senha)
        {
            // Criando Conexão
            MySqlConnection conexao = null;

            try
            {
                conexao.Open();

                MySqlCommand add_usuario = new MySqlCommand(
                     $@"
                        INSERT INTO tb_usuarios VALUES (@pecado, @nome, @usuario, @telefone, @senha);
                        CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                        GRANT SELECT ON db_agenda.tb_categorias TO '{usuario}'@'%';
                    ",
                     conexao
                     );

                add_usuario.Parameters.AddWithValue("@nome", nome);
                add_usuario.Parameters.AddWithValue("@usuario", usuario);
                add_usuario.Parameters.AddWithValue("@telefone", telefone);
                add_usuario.Parameters.AddWithValue("@senha", senha);

                // retorna a quantidade de linhas afetadas 
                if (add_usuario.ExecuteNonQuery() > 0)
                {
                    // deu certo o usuario foi inserido

                    return true;
                }
                else
                {
                    // usuario nao cadastrado

                    return false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"erro ao tentar cadastrar {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
