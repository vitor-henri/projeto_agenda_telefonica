namespace projeto_agenda_telefonica.Views
{
    partial class FrmMain
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
            btn_add = new Button();
            btn_editar = new Button();
            btn_excluir = new Button();
            dgv_Categorias = new DataGridView();
            btn_atualizar = new Button();
            lblnome = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbltelefone = new Label();
            lblusuario = new Label();
            btn_add_contatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(182, 321);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(93, 35);
            btn_add.TabIndex = 0;
            btn_add.Text = "Adcionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(281, 321);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(93, 35);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(380, 321);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(93, 35);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // dgv_Categorias
            // 
            dgv_Categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categorias.Location = new Point(182, 101);
            dgv_Categorias.Name = "dgv_Categorias";
            dgv_Categorias.Size = new Size(291, 214);
            dgv_Categorias.TabIndex = 3;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Location = new Point(182, 60);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(291, 35);
            btn_atualizar.TabIndex = 4;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = true;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(550, 113);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(16, 15);
            lblnome.TabIndex = 5;
            lblnome.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 80);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 6;
            label1.Text = "Informações Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(550, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(620, 98);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(587, 136);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "telefone";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(602, 151);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(16, 15);
            lbltelefone.TabIndex = 10;
            lbltelefone.Text = "...";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(634, 113);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(16, 15);
            lblusuario.TabIndex = 11;
            lblusuario.Text = "...";
            // 
            // btn_add_contatos
            // 
            btn_add_contatos.Location = new Point(268, 375);
            btn_add_contatos.Name = "btn_add_contatos";
            btn_add_contatos.Size = new Size(119, 35);
            btn_add_contatos.TabIndex = 12;
            btn_add_contatos.Text = "Adcionar Contatos";
            btn_add_contatos.UseVisualStyleBackColor = true;
            btn_add_contatos.Click += btn_add_contatos_Click;
            // 
            // FrmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 450);
            Controls.Add(btn_add_contatos);
            Controls.Add(lblusuario);
            Controls.Add(lbltelefone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblnome);
            Controls.Add(btn_atualizar);
            Controls.Add(dgv_Categorias);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_add);
            Name = "FrmContatos";
            Text = "FrmProfile";
            Load += FrmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_editar;
        private Button btn_excluir;
        private DataGridView dgv_Categorias;
        private Button btn_atualizar;
        private Label lblnome;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbltelefone;
        private Label lblusuario;
        private Button btn_add_contatos;
    }
}