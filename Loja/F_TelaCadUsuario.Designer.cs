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
            btnLogout = new Button();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnVisualizar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(251, 121);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Cadastrar Nome Completo";
            txtNome.Size = new Size(300, 27);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(251, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Cadastrar E-mail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 11F);
            txtSenha.Location = new Point(251, 187);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Cadastrar Senha";
            txtSenha.Size = new Size(220, 27);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnCad
            // 
            btnCad.Font = new Font("Segoe UI", 11F);
            btnCad.Location = new Point(360, 231);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(83, 33);
            btnCad.TabIndex = 3;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top;
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.Location = new Point(713, 48);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Voltar";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 34);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 5;
            label1.Text = "Gerenciar Usuários";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 6;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Font = new Font("Segoe UI", 11F);
            btnVisualizar.Location = new Point(707, 265);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(81, 29);
            btnVisualizar.TabIndex = 7;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // F_TelaCadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVisualizar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(btnCad);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "F_TelaCadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button btnCad;
        private Button btnLogout;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnVisualizar;
    }
}