namespace Loja
{
    partial class F_TelaCadUsuario
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnCad = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(251, 139);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Cadastrar Nome Completo";
            txtNome.Size = new Size(300, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(251, 187);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Cadastrar E-mail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(251, 240);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Cadastrar Senha";
            txtSenha.Size = new Size(220, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnCad
            // 
            btnCad.Location = new Point(324, 316);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(75, 23);
            btnCad.TabIndex = 3;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // F_TelaCadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCad);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "F_TelaCadUsuario";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnCad;
    }
}