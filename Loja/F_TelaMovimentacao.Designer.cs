namespace Loja
{
    partial class F_TelaMovimentacao
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
            btnLogout = new Button();
            btnCadMovimentacao = new Button();
            cmbTipo = new ComboBox();
            label2 = new Label();
            txtQuantidade = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            dgvMovimentacao = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            btnFiltrar = new Button();
            cmbFiltrar = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacao).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnCadMovimentacao);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 180);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 11F);
            btnLogout.Location = new Point(684, 39);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(91, 27);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Voltar";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCadMovimentacao
            // 
            btnCadMovimentacao.Font = new Font("Segoe UI", 11F);
            btnCadMovimentacao.Location = new Point(743, 139);
            btnCadMovimentacao.Name = "btnCadMovimentacao";
            btnCadMovimentacao.Size = new Size(91, 27);
            btnCadMovimentacao.TabIndex = 3;
            btnCadMovimentacao.Text = "Registrar";
            btnCadMovimentacao.UseVisualStyleBackColor = true;
            btnCadMovimentacao.Click += btnCadMovimentacao_Click;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "", "Entrada", "Saída" });
            cmbTipo.Location = new Point(266, 138);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 28);
            cmbTipo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.Location = new Point(266, 9);
            label2.Name = "label2";
            label2.Size = new Size(273, 46);
            label2.TabIndex = 4;
            label2.Text = "Movimentações";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 11F);
            txtQuantidade.Location = new Point(500, 138);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Size = new Size(151, 27);
            txtQuantidade.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F);
            txtId.Location = new Point(24, 138);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id do Produto";
            txtId.Size = new Size(100, 27);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 86);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 0;
            label1.Text = "Nova movimentação";
            // 
            // dgvMovimentacao
            // 
            dgvMovimentacao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimentacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimentacao.Dock = DockStyle.Bottom;
            dgvMovimentacao.Location = new Point(0, 378);
            dgvMovimentacao.Name = "dgvMovimentacao";
            dgvMovimentacao.Size = new Size(846, 150);
            dgvMovimentacao.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(cmbFiltrar);
            panel2.Location = new Point(0, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 100);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 12);
            label3.Name = "label3";
            label3.Size = new Size(211, 21);
            label3.TabIndex = 8;
            label3.Text = "Visualizar Movimentações";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Font = new Font("Segoe UI", 11F);
            btnFiltrar.Location = new Point(302, 55);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 28);
            btnFiltrar.TabIndex = 4;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // cmbFiltrar
            // 
            cmbFiltrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrar.Font = new Font("Segoe UI", 11F);
            cmbFiltrar.FormattingEnabled = true;
            cmbFiltrar.Items.AddRange(new object[] { "Todas", "Entrada", "Saída" });
            cmbFiltrar.Location = new Point(24, 55);
            cmbFiltrar.Name = "cmbFiltrar";
            cmbFiltrar.Size = new Size(121, 28);
            cmbFiltrar.TabIndex = 0;
            // 
            // F_TelaMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 528);
            Controls.Add(panel2);
            Controls.Add(dgvMovimentacao);
            Controls.Add(panel1);
            Name = "F_TelaMovimentacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_TelaMovimentacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentacao).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtQuantidade;
        private TextBox txtId;
        private Label label1;
        private Button btnCadMovimentacao;
        private ComboBox cmbTipo;
        private Label label2;
        private DataGridView dgvMovimentacao;
        private Panel panel2;
        private Button btnFiltrar;
        private ComboBox cmbFiltrar;
        private Button btnLogout;
        private Label label3;
    }
}