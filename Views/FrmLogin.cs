using projeto_agenda_telefonica.Views;

namespace projeto_agenda_telefonica
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
            this.Hide();
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