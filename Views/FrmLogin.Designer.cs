namespace projeto_agenda_telefonica
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            txt_usuario = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_senha = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_logar = new Button();
            btn_cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(325, 65);
            label1.Name = "label1";
            label1.Size = new Size(162, 27);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo ao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(285, 103);
            label2.Name = "label2";
            label2.Size = new Size(238, 44);
            label2.TabIndex = 1;
            label2.Text = "OVERWORLD";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(297, 180);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(212, 23);
            txt_usuario.TabIndex = 2;
            txt_usuario.Text = "Digite seu usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 147);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 3;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 217);
            label4.Name = "label4";
            label4.Size = new Size(70, 30);
            label4.TabIndex = 5;
            label4.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(297, 250);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(212, 23);
            txt_senha.TabIndex = 4;
            txt_senha.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(520, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-49, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(329, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btn_logar
            // 
            btn_logar.BackColor = Color.Lime;
            btn_logar.FlatStyle = FlatStyle.Flat;
            btn_logar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logar.ForeColor = Color.White;
            btn_logar.Location = new Point(297, 279);
            btn_logar.Name = "btn_logar";
            btn_logar.Size = new Size(100, 34);
            btn_logar.TabIndex = 8;
            btn_logar.Text = "Logar";
            btn_logar.UseVisualStyleBackColor = false;
            btn_logar.Click += btn_logar_Click;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Red;
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = Color.White;
            btn_cadastrar.Location = new Point(414, 279);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(95, 34);
            btn_cadastrar.TabIndex = 9;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cadastrar);
            Controls.Add(btn_logar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txt_senha);
            Controls.Add(label3);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_usuario;
        private Label label3;
        private Label label4;
        private TextBox txt_senha;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_logar;
        private Button btn_cadastrar;
    }
}
