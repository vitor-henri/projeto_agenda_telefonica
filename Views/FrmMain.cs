using projeto_agenda_telefonica.Controllers;
using projeto_agenda_telefonica.GlobalVariable;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void AtualizarDgvCategorias()
        {
            // atualizar a lista de categorias
            dgv_Categorias.DataSource = new CategoriaController().GetCategorias();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            FrmAddCategoria frmAddCategoria = new FrmAddCategoria();
            frmAddCategoria.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int categoria = Convert.ToInt32(dgv_Categorias.SelectedRows[0].Cells[0].Value);
            CategoriaController editarcategoria = new CategoriaController();

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int categoria = Convert.ToInt32(dgv_Categorias.SelectedRows[0].Cells[0].Value);
            CategoriaController excluircategoria = new CategoriaController();
            excluircategoria.DeletarCategoria(categoria);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvCategorias();
        }

        private void FrmContatos_Load(object sender, EventArgs e)
        {
            // quando atualizar o forms ele atualiza automaticamente a lista de categorias
            this.AtualizarDgvCategorias();

            lbl_bem_vindo.Text = $"Bem vindo(a) {UserSession.InfoUsuario["nome"]}";

            lblnome.Text = UserSession.InfoUsuario["nome"].ToString();

            lblusuario.Text = UserSession.InfoUsuario["usuario"].ToString();

            lbltelefone.Text = UserSession.InfoUsuario["telefone"].ToString();

        }

        private void btn_add_contatos_Click(object sender, EventArgs e)
        {
            FrmContatos telaContatos = new FrmContatos();
            telaContatos.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
