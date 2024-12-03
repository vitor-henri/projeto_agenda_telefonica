using projeto_agenda_telefonica.Controllers;
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
    public partial class FrmContatos : Form
    {
        public FrmContatos()
        {
            InitializeComponent();
        }
        private void AtualizarDgvContatos()
        {
            dgv_contatos.DataSource = new UserController().GetContatos();
        }
        private void FrmContatos_Load(object sender, EventArgs e)
        {
            this.AtualizarDgvContatos();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarDgvContatos();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
