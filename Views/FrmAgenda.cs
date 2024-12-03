using projeto_agenda_telefonica.Controllers;
using projeto_agenda_telefonica.Data;
using projeto_agenda_telefonica.GlobalVariable;
using projeto_agenda_telefonica.Views;

namespace projeto_agenda_telefonica
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (new UserController().ValidarUsuario(txt_usuario.Text, txt_senha.Text))
            {
                // Usuário Validado

                UserSession.Conexao = ConexaoDB.Conexao(txt_usuario.Text, txt_senha.Text);

                UserSession.InfoUsuario = new UserController().PegarUsuario(txt_usuario.Text);

                FrmMain ProfileTela = new FrmMain();

                this.Hide();

                ProfileTela.ShowDialog();

                this.Close();
            }

            else
            {
                // Usuário Não Validado

                MessageBox.Show("Usuário ou senha incorreta.", "Tente Novamente!");
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            // Vendo se o usuario digitou mais de 8 caracteres para liberar acesso
            if (txt_usuario.Text != "" && txt_senha.Text.Length >= 8)
            {
                btn_logar.Enabled = true;
            }

            else
            {
                btn_logar.Enabled = false;
            }
        }
    }
}