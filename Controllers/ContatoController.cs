using projeto_agenda_telefonica.GlobalVariable;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_agenda_telefonica.Controllers
{
    internal class ContatoController
    {
        public bool CreateContato(string nome, string? endereco, string email)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdInsertContato = new MySqlCommand(
                        "INSERT INTO tb_contatos (nome, endereco, email) VALUES (@nome, @endereco, @email);",
                        connection
                    );

                    cmdInsertContato.Parameters.AddWithValue("@nome", nome);

                    cmdInsertContato.Parameters.AddWithValue("@endereco", endereco);

                    cmdInsertContato.Parameters.AddWithValue("@email", email);

                    if (cmdInsertContato.ExecuteNonQuery() > 0)
                    {
                        // Contato Inserido

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

        public bool DeleteContato(string idContato)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdDeleteContato = new MySqlCommand(
                        "DELETE FROM tb_contatos WHERE tb_contatos.id_contato = @idContato;",
                        connection
                    );

                    cmdDeleteContato.Parameters.AddWithValue("@idContato", idContato);

                    if (cmdDeleteContato.ExecuteNonQuery() > 0)
                    {
                        // Contato apagado

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

        public bool CreateTelefoneContato(string telefone, string descricao, int idContato)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdInsertTelefone = new MySqlCommand(
                        "INSERT INTO tb_telefones (telefone, descricao, id_contato) VALUES (@telefone, @descricao, @idContato);",
                        connection
                    );

                    cmdInsertTelefone.Parameters.AddWithValue("@telefone", telefone);

                    cmdInsertTelefone.Parameters.AddWithValue("@descricao", descricao);

                    cmdInsertTelefone.Parameters.AddWithValue("@idContato", idContato);

                    if (cmdInsertTelefone.ExecuteNonQuery() > 0)
                    {
                        // Telefone do contato criado e relacionado

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

        public bool DeleteTelefoneContato(int idTelefone)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdDeleteTelefone = new MySqlCommand(
                        "DELETE FROM tb_telefones WHERE tb_telefones.id_telefone = @idTelefone;",
                        connection
                    );

                    cmdDeleteTelefone.Parameters.AddWithValue("@idTelefone", idTelefone);

                    if (cmdDeleteTelefone.ExecuteNonQuery() > 0)
                    {
                        // Telefone do contato excluído

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

        public bool AddCategoriaContato(string idContato, string idCategoria)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdInsertAfinidade = new MySqlCommand(
                        "INSERT INTO tb_afinidades (id_contato, id_categoria) VALUES (@idContato, @idCategoria);",
                        connection
                    );

                    cmdInsertAfinidade.Parameters.AddWithValue("@idContato", idContato);

                    cmdInsertAfinidade.Parameters.AddWithValue("@idCategoria", idCategoria);

                    if (cmdInsertAfinidade.ExecuteNonQuery() > 0)
                    {
                        // Categoria adicionada ao contato

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

        public bool RemoveCategoriaContato(int idAfinidade)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdDeleteAfinidade = new MySqlCommand(
                        "DELETE FROM tb_afinidades WHERE tb_afinidades.id_afinidade = @idAfinidade;",
                        connection
                    );

                    cmdDeleteAfinidade.Parameters.AddWithValue("@idAfinidade", idAfinidade);

                    if (cmdDeleteAfinidade.ExecuteNonQuery() > 0)
                    {
                        // Categoria removida do contato

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

        public DataTable? GetTelefonesContato(int idContato)
        {
            MySqlConnection connection = UserSession.Conexao;

            if (connection != null)
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmdSelectTelefones = new MySqlCommand(
                        "SELECT * FROM tb_telefones WHERE tb_telefones.id_contato = @idContato;",
                        connection
                    );

                    cmdSelectTelefones.Parameters.AddWithValue("@idContato", idContato);

                    MySqlDataAdapter adpSelectTelefones = new MySqlDataAdapter(
                        cmdSelectTelefones
                    );

                    DataTable table = new DataTable();

                    adpSelectTelefones.Fill(table);

                    // Tabela contendo os telefones do contato
                    return table;
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                    return null;
                }

                finally
                {
                    connection.Close();
                }
            }

            else
            {
                return null;
            }
        }
    }
}
