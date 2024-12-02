using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_agenda_telefonica.Views
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            // liberando o botão de login caso os dados inseridos estejam certos conforme a formatação
            if (
                txt_nome.Text != ""

                && txt_usuario.Text != ""

                && txt_telefone.Text != ""

                && txt_senha.Text.Length >= 8

                && txt_repetir_senha.Text != ""

                && txt_repetir_senha.Text == txt_senha.Text

                )
            {
                btn_logar.Enabled = true;
            }
            else
            {
                btn_logar.Enabled = false;
            }
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

        }
    }
}
