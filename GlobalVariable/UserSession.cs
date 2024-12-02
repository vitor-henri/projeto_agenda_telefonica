using MySql.Data.MySqlClient;
using projeto_agenda_telefonica.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_agenda_telefonica.GlobalVariable
{
    static public class UserSession
    {
        // usamos _ no começo quando a variavel é privada
        static private MySqlConnection _conexao = null;

        static public MySqlConnection Conexao
        {
            get
            {
                return _conexao;
            }
            set
            {
                _conexao = value;
            }
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

    public bool ModificarSenha(string usuario, string novaSenha)
    {
        MySqlConnection connection = UserSession.Conexao;

        if (connection != null)
        {
            try
            {
                connection.Open();

                MySqlCommand cmdUpdatePassword = new MySqlCommand(
                    $@"
                            UPDATE tb_usuarios SET tb_usuarios.senha = @nova_senha WHERE tb_usuarios.usuario = @usuario;
                            ALTER USER '{usuario}'@'%' IDENTIFIED BY '{novaSenha}'
                        ",
                    connection
                );

                cmdUpdatePassword.Parameters.AddWithValue("@usuario", usuario);

                cmdUpdatePassword.Parameters.AddWithValue("@nova_senha", novaSenha);

                if (cmdUpdatePassword.ExecuteNonQuery() > 0)
                {
                    // Senha do usuário alterada

                    return true;
                }

                else
                {
                    // Erro

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

        else
        {
            return false;
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
}
