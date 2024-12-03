using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using projeto_agenda_telefonica.Data;
using projeto_agenda_telefonica.GlobalVariable;

namespace projeto_agenda_telefonica.Controllers
{
    internal class UserController
    {
        public bool CriarUsuario(string nome, string usuario, string telefone, string senha)
        {
            // Criando Conexão
            MySqlConnection connection = ConexaoDB.Conexao();

            try
            {
                connection.Open();

                MySqlCommand add_usuario = new MySqlCommand(
                     $@"
                        INSERT INTO tb_usuarios VALUES (@nome, @usuario, @telefone, @senha);
                        CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                        GRANT SELECT ON db_agenda.tb_categorias TO '{usuario}'@'%';
                    ", connection);

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
                connection.Close();
            }
        }
        public bool DeletarUsuario(string usuario)
        {
            MySqlConnection connection = ConexaoDB.Conexao();

            try
            {
                connection.Open();

                MySqlCommand cmdDeleteUser = new MySqlCommand(
                    $@"
                        DELETE FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;
                        DROP USER '{usuario}'@'%';
                    ",
                    connection
                );

                cmdDeleteUser.Parameters.AddWithValue("@usuario", usuario);

                cmdDeleteUser.ExecuteNonQuery();

                // Usuário Deletado

                return true;
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }
        }
        public DataTable GetContatos()
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlDataAdapter adpGetContatos = new MySqlDataAdapter(
                        "SELECT tb_contatos.id_contato AS 'ID', tb_contatos.nome AS 'Nome', tb_contatos.endereco AS 'Endereço', tb_contatos.email AS 'E-Mail' FROM tb_contatos WHERE tb_contatos.usuario = SUBSTRING_INDEX(USER(), '@', 1);",
                        connection
                    );

                    DataTable table = new DataTable();

                    adpGetContatos.Fill(table);

                    // Tabela contendo os contatos
                    return table;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                    return new DataTable();
                }

                finally
                {
                    connection.Close();
                }
            }

            else
            {
                return new DataTable();
            }
        }
        public Dictionary<string, object>? PegarUsuario(string usuario)
        {
            MySqlConnection connection = ConexaoDB.Conexao();

            try
            {
                connection.Open();

                MySqlCommand cmdGetUser = new MySqlCommand(
                    "SELECT tb_usuarios.nome, tb_usuarios.usuario, tb_usuarios.telefone, tb_usuarios.senha FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;",
                    connection
                );

                cmdGetUser.Parameters.AddWithValue("@usuario", usuario);

                MySqlDataReader result = cmdGetUser.ExecuteReader();

                if (result.Read())
                {
                    // Passando os dados do MySqlDataReader para o Dicionario para poder manter os dados mesmo depois da conexão fechar

                    // Tipo Object -> Armazena qualquer tipo de dado
                    Dictionary<string, object> returnValue = new Dictionary<string, object>();

                    for (int i = 0; i < result.FieldCount; i++)
                    {
                        returnValue[result.GetName(i)] = result.GetValue(i);
                    }

                    // Dicionário com as informações do usuário

                    return returnValue;
                }

                else
                {
                    // Erro

                    return null;
                }
            }

            catch (Exception)
            {
                return null;
            }

            finally
            {
                connection.Close();
            }
        }
        public bool ValidarUsuario(string usuario, string senha)
        {
            MySqlConnection connection = ConexaoDB.Conexao();

            try
            {
                connection.Open();

                MySqlCommand cmdSelectUser = new MySqlCommand(
                    "SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha;",
                    connection
                );

                cmdSelectUser.Parameters.AddWithValue("@usuario", usuario);

                cmdSelectUser.Parameters.AddWithValue("@senha", senha);

                // Retorna o conjunto dos resultados gerados (ExecuteReader)
                MySqlDataReader result = cmdSelectUser.ExecuteReader();

                if (result.Read())
                {
                    // Usuário Validado

                    return true;
                }

                else
                {
                    // Usuário Não Validado

                    return false;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                return false;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
