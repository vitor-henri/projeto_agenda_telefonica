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

        // usando dicionario novamente para não perder os dados do usuario mesmo depois da conexão fechar
        static private Dictionary<string, object> _infousuario = null;

        static public Dictionary<string, object> InfoUsuario
        {

            get
            {
                return _infousuario;
            }

            set
            {
                _infousuario = value;
            }

        }
    }
}
