namespace projeto_agenda_telefonica.Views
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            label1 = new Label();
            label2 = new Label();
            txt_nome = new TextBox();
            txt_usuario = new TextBox();
            label3 = new Label();
            txt_telefone = new TextBox();
            label4 = new Label();
            txt_senha = new TextBox();
            label5 = new Label();
            txt_repetir_senha = new TextBox();
            label6 = new Label();
            btn_logar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 9);
            label2.Name = "label2";
            label2.Size = new Size(254, 27);
            label2.TabIndex = 1;
            label2.Text = "Registre-se no Mundo";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(45, 63);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(182, 23);
            txt_nome.TabIndex = 2;
            txt_nome.TextChanged += txt_TextChanged;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(45, 127);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(182, 23);
            txt_usuario.TabIndex = 4;
            txt_usuario.TextChanged += txt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(45, 197);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(182, 23);
            txt_telefone.TabIndex = 6;
            txt_telefone.TextChanged += txt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 169);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Telefone";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(45, 270);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(182, 23);
            txt_senha.TabIndex = 8;
            txt_senha.UseSystemPasswordChar = true;
            txt_senha.TextChanged += txt_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 242);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 7;
            label5.Text = "Senha";
            // 
            // txt_repetir_senha
            // 
            txt_repetir_senha.Location = new Point(45, 348);
            txt_repetir_senha.Name = "txt_repetir_senha";
            txt_repetir_senha.PasswordChar = '*';
            txt_repetir_senha.Size = new Size(182, 23);
            txt_repetir_senha.TabIndex = 10;
            txt_repetir_senha.UseSystemPasswordChar = true;
            txt_repetir_senha.TextChanged += txt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 320);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 9;
            label6.Text = "Repetir Senha";
            // 
            // btn_logar
            // 
            btn_logar.BackColor = Color.Lime;
            btn_logar.Enabled = false;
            btn_logar.FlatStyle = FlatStyle.Flat;
            btn_logar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logar.ForeColor = Color.White;
            btn_logar.Location = new Point(45, 395);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(182, 34);
            btn_logar.TabIndex = 11;
            btn_logar.Text = "Jogar";
            btn_logar.UseVisualStyleBackColor = false;
            btn_logar.Click += btn_logar_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 450);
            Controls.Add(btn_logar);
            Controls.Add(txt_repetir_senha);
            Controls.Add(label6);
            Controls.Add(txt_senha);
            Controls.Add(label5);
            Controls.Add(txt_telefone);
            Controls.Add(label4);
            Controls.Add(txt_usuario);
            Controls.Add(label3);
            Controls.Add(txt_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_nome;
        private TextBox txt_usuario;
        private Label label3;
        private TextBox txt_telefone;
        private Label label4;
        private TextBox txt_senha;
        private Label label5;
        private TextBox txt_repetir_senha;
        private Label label6;
        private Button btn_logar;
    }
}