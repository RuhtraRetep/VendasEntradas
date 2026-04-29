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
            lblNome = new Label();
            btnCadUsuario = new Button();
            btnCadProdutos = new Button();
            btnMovimentacao = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label1);
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
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 1;
            label1.Text = "Tela Principal";
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(683, 29);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "label1";
            // 
            // btnCadUsuario
            // 
            btnCadUsuario.Location = new Point(107, 172);
            btnCadUsuario.Name = "btnCadUsuario";
            btnCadUsuario.Size = new Size(100, 102);
            btnCadUsuario.TabIndex = 1;
            btnCadUsuario.Text = "Cadastrar\r\nUsuários\r\n";
            btnCadUsuario.UseVisualStyleBackColor = true;
            btnCadUsuario.Click += btnCadUsuario_Click;
            // 
            // btnCadProdutos
            // 
            btnCadProdutos.Location = new Point(315, 172);
            btnCadProdutos.Name = "btnCadProdutos";
            btnCadProdutos.Size = new Size(100, 102);
            btnCadProdutos.TabIndex = 2;
            btnCadProdutos.Text = "Cadastrar\r\nProdutos";
            btnCadProdutos.UseVisualStyleBackColor = true;
            btnCadProdutos.Click += btnCadProdutos_Click;
            // 
            // btnMovimentacao
            // 
            btnMovimentacao.Location = new Point(542, 172);
            btnMovimentacao.Name = "btnMovimentacao";
            btnMovimentacao.Size = new Size(100, 102);
            btnMovimentacao.TabIndex = 3;
            btnMovimentacao.Text = "Movimentação";
            btnMovimentacao.UseVisualStyleBackColor = true;
            btnMovimentacao.Click += btnMovimentacao_Click;
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
    }
}