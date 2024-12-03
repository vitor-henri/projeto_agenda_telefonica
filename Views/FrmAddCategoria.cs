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
    public partial class FrmAddCategoria : Form
    {
        public FrmAddCategoria()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // adcionando a categoria
            // instanciando a classe categoriacontroller
            bool addCategoria = new CategoriaController().CreateCategoria(txt_add.Text);

            if (addCategoria)
            {

                this.Close();

                // categoria cadastrada

                MessageBox.Show("Categoria cadastrada");

            }

            else
            {
                // Não deu certo

                MessageBox.Show("Ocorreu um erro ao inserir");

            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
