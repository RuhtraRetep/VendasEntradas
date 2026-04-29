namespace Loja
{
    partial class F_TelaCadProduto
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
            txtQuantidadeAtual = new TextBox();
            txtQuantidadeMinima = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCad = new Button();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            qtdAtual = new DataGridViewTextBoxColumn();
            qtdMinima = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(63, 103);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome do Produto";
            txtNome.Size = new Size(217, 23);
            txtNome.TabIndex = 0;
            // 
            // txtQuantidadeAtual
            // 
            txtQuantidadeAtual.Location = new Point(351, 103);
            txtQuantidadeAtual.Name = "txtQuantidadeAtual";
            txtQuantidadeAtual.PlaceholderText = "Quantidade ";
            txtQuantidadeAtual.Size = new Size(137, 23);
            txtQuantidadeAtual.TabIndex = 1;
            // 
            // txtQuantidadeMinima
            // 
            txtQuantidadeMinima.Location = new Point(558, 103);
            txtQuantidadeMinima.Name = "txtQuantidadeMinima";
            txtQuantidadeMinima.PlaceholderText = "Quantidade mínima";
            txtQuantidadeMinima.Size = new Size(137, 23);
            txtQuantidadeMinima.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 3;
            label1.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCad);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtQuantidadeMinima);
            panel1.Controls.Add(txtQuantidadeAtual);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 173);
            panel1.TabIndex = 4;
            // 
            // btnCad
            // 
            btnCad.Location = new Point(706, 144);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(75, 23);
            btnCad.TabIndex = 4;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            btnCad.Click += btnCad_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, nome, qtdAtual, qtdMinima });
            dgvProdutos.Dock = DockStyle.Bottom;
            dgvProdutos.Location = new Point(0, 253);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.Size = new Size(800, 197);
            dgvProdutos.TabIndex = 5;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Código ";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nome
            // 
            nome.DataPropertyName = "nome";
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // qtdAtual
            // 
            qtdAtual.DataPropertyName = "estoque_atual";
            qtdAtual.HeaderText = "Quantidade em Estoque";
            qtdAtual.Name = "qtdAtual";
            qtdAtual.ReadOnly = true;
            // 
            // qtdMinima
            // 
            qtdMinima.DataPropertyName = "estoque_minimo";
            qtdMinima.HeaderText = "Quantidade Mínima";
            qtdMinima.Name = "qtdMinima";
            qtdMinima.ReadOnly = true;
            // 
            // F_TelaCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(panel1);
            Name = "F_TelaCadProduto";
            Text = "F_TelaCadProduto";
            Load += F_TelaCadProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtQuantidadeAtual;
        private TextBox txtQuantidadeMinima;
        private Label label1;
        private Panel panel1;
        private Button btnCad;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn qtdAtual;
        private DataGridViewTextBoxColumn qtdMinima;
    }
}