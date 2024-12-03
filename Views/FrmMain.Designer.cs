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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btn_add = new Button();
            btn_editar = new Button();
            btn_excluir = new Button();
            dgv_Categorias = new DataGridView();
            btn_atualizar = new Button();
            lblnome = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbltelefone = new Label();
            lblusuario = new Label();
            btn_add_contatos = new Button();
            lbl_bem_vindo = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Lime;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(201, 321);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(93, 35);
            btn_add.TabIndex = 0;
            btn_add.Text = "Adcionar";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.Lime;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_editar.ForeColor = Color.White;
            btn_editar.Location = new Point(300, 321);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(93, 35);
            btn_editar.TabIndex = 1;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.Lime;
            btn_excluir.FlatStyle = FlatStyle.Flat;
            btn_excluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_excluir.ForeColor = Color.White;
            btn_excluir.Location = new Point(399, 321);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(93, 35);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // dgv_Categorias
            // 
            dgv_Categorias.BackgroundColor = Color.White;
            dgv_Categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categorias.Location = new Point(201, 101);
            dgv_Categorias.Name = "dgv_Categorias";
            dgv_Categorias.Size = new Size(291, 214);
            dgv_Categorias.TabIndex = 3;
            // 
            // btn_atualizar
            // 
            btn_atualizar.BackColor = Color.Lime;
            btn_atualizar.FlatStyle = FlatStyle.Flat;
            btn_atualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atualizar.ForeColor = Color.White;
            btn_atualizar.Location = new Point(201, 60);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(291, 35);
            btn_atualizar.TabIndex = 4;
            btn_atualizar.Text = "Refresh";
            btn_atualizar.UseVisualStyleBackColor = false;
            btn_atualizar.Click += btn_atualizar_Click;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(15, 53);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(16, 15);
            lblnome.TabIndex = 5;
            lblnome.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 32);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "usuario";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 88);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "telefone";
            // 
            // lbltelefone
            // 
            lbltelefone.AutoSize = true;
            lbltelefone.Location = new Point(58, 103);
            lbltelefone.Name = "lbltelefone";
            lbltelefone.Size = new Size(16, 15);
            lbltelefone.TabIndex = 10;
            lbltelefone.Text = "...";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(101, 57);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(16, 15);
            lblusuario.TabIndex = 11;
            lblusuario.Text = "...";
            // 
            // btn_add_contatos
            // 
            btn_add_contatos.BackColor = Color.Lime;
            btn_add_contatos.FlatStyle = FlatStyle.Flat;
            btn_add_contatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_add_contatos.ForeColor = Color.White;
            btn_add_contatos.Location = new Point(257, 376);
            btn_add_contatos.Name = "btn_add_contatos";
            btn_add_contatos.Size = new Size(184, 35);
            btn_add_contatos.TabIndex = 12;
            btn_add_contatos.Text = "Adcionar Contatos";
            btn_add_contatos.UseVisualStyleBackColor = false;
            btn_add_contatos.Click += btn_add_contatos_Click;
            // 
            // lbl_bem_vindo
            // 
            lbl_bem_vindo.AutoSize = true;
            lbl_bem_vindo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_bem_vindo.Location = new Point(201, 25);
            lbl_bem_vindo.Name = "lbl_bem_vindo";
            lbl_bem_vindo.Size = new Size(0, 32);
            lbl_bem_vindo.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblusuario);
            groupBox1.Controls.Add(lbltelefone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblnome);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(513, 101);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 152);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(498, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-37, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(lbl_bem_vindo);
            Controls.Add(btn_add_contatos);
            Controls.Add(btn_atualizar);
            Controls.Add(dgv_Categorias);
            Controls.Add(btn_excluir);
            Controls.Add(btn_editar);
            Controls.Add(btn_add);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProfile";
            Load += FrmContatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbltelefone;
        private Label lblusuario;
        private Button btn_add_contatos;
        private Label lbl_bem_vindo;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}