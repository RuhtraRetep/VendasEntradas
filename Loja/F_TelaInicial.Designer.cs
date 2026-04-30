namespace Loja
{
    partial class F_TelaInicial
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblNome = new Label();
            btnCadUsuario = new Button();
            btnCadProdutos = new Button();
            btnMovimentacao = new Button();
            btnVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnVoltar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblNome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(306, 29);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 1;
            label1.Text = "Tela Principal";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 40);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 0;
            label2.Text = "Seja Bem-Vindo";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(20, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(48, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "label1";
            // 
            // btnCadUsuario
            // 
            btnCadUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadUsuario.Location = new Point(111, 172);
            btnCadUsuario.Name = "btnCadUsuario";
            btnCadUsuario.Size = new Size(128, 102);
            btnCadUsuario.TabIndex = 1;
            btnCadUsuario.Text = "Cadastrar\r\nUsuários\r\n";
            btnCadUsuario.UseVisualStyleBackColor = true;
            btnCadUsuario.Click += btnCadUsuario_Click;
            // 
            // btnCadProdutos
            // 
            btnCadProdutos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCadProdutos.Location = new Point(336, 172);
            btnCadProdutos.Name = "btnCadProdutos";
            btnCadProdutos.Size = new Size(128, 102);
            btnCadProdutos.TabIndex = 2;
            btnCadProdutos.Text = "Cadastrar\r\nProdutos";
            btnCadProdutos.UseVisualStyleBackColor = true;
            btnCadProdutos.Click += btnCadProdutos_Click;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnMovimentacao.Location = new Point(542, 172);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(128, 102);
            btnMovimentacao.TabIndex = 3;
            btnMovimentacao.Text = "Movimentação";
            btnMovimentacao.UseVisualStyleBackColor = true;
            btnMovimentacao.Click += btnMovimentacao_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 11F);
            btnVoltar.Location = new Point(711, 39);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(68, 29);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // F_TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMovimentacao);
            Controls.Add(btnCadProdutos);
            Controls.Add(btnCadUsuario);
            Controls.Add(panel1);
            Name = "F_TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_TelaInicial";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblNome;
        private Button btnCadUsuario;
        private Button btnCadProdutos;
        private Button btnMovimentacao;
        private Label label2;
        private Button btnVoltar;
    }
}