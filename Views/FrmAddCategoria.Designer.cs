namespace projeto_agenda_telefonica.Views
{
    partial class FrmAddCategoria
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
            txt_add = new TextBox();
            btn_salvar = new Button();
            btn_voltar = new Button();
            SuspendLayout();
            // 
            // txt_add
            // 
            txt_add.Location = new Point(27, 28);
            txt_add.Multiline = true;
            txt_add.Name = "txt_add";
            txt_add.Size = new Size(431, 40);
            txt_add.TabIndex = 0;
            txt_add.Text = "Nome da categoria";
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(272, 87);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(186, 45);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.Location = new Point(27, 87);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(193, 45);
            btn_voltar.TabIndex = 2;
            btn_voltar.Text = "Cancelar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // FrmAddCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 245);
            Controls.Add(btn_voltar);
            Controls.Add(btn_salvar);
            Controls.Add(txt_add);
            Name = "FrmAddCategoria";
            Text = "FrmAddCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_add;
        private Button btn_salvar;
        private Button btn_voltar;
    }
}