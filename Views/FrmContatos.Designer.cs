namespace projeto_agenda_telefonica.Views
{
    partial class FrmContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgv_contatos = new DataGridView();
            btn_atualizar = new Button();
            btn_voltar = new Button();
            btn_add_contato = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 45);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Contatos";
            // 
            // dgv_contatos
            // 
            dgv_contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_contatos.Location = new Point(269, 74);
            dgv_contatos.Name = "dgv_contatos";
            dgv_contatos.Size = new Size(277, 265);
            dgv_contatos.TabIndex = 1;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(269, 386);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(131, 39);
            btn_atualizar.TabIndex = 2;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(418, 386);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(128, 39);
            btn_voltar.TabIndex = 3;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_add_contato
            // 
            btn_add_contato.Location = new Point(269, 345);
            btn_add_contato.Name = "btn_add_contato";
            btn_add_contato.Size = new Size(277, 35);
            btn_add_contato.TabIndex = 4;
            btn_add_contato.Text = "Adcionar";
            btn_add_contato.UseVisualStyleBackColor = true;
            btn_add_contato.Click += btn_add_contato_Click;
            // 
            // FrmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_contato);
            Controls.Add(btn_voltar);
            Controls.Add(btn_atualizar);
            Controls.Add(dgv_contatos);
            Controls.Add(label1);
            Name = "FrmContatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContatos";
            Load += FrmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_contatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_contatos;
        private Button btn_atualizar;
        private Button btn_voltar;
        private Button btn_add_contato;
    }
}