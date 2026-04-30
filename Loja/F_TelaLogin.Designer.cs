namespace Loja
{
    partial class F_TelaLogin
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
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(528, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Seu E-mail";
            txtEmail.Size = new Size(186, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(528, 192);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Sua Senha";
            txtSenha.Size = new Size(186, 27);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 11F);
            btnEntrar.Location = new Point(584, 257);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 29);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(580, 73);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 450);
            panel1.TabIndex = 4;
            // 
            // F_TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "F_TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
		private TextBox txtSenha;
		private TextBox textBox2;
        private Button btnEntrar;
        private Label label1;
        private Panel panel1;
    }
}
