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
            label1 = new Label();
            txtId = new TextBox();
            txtQuantidade = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            cmbTipo = new ComboBox();
            comboBox2 = new ComboBox();
            btnCadMovimentacao = new Button();
            btnFiltrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnCadMovimentacao);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 180);
            panel1.TabIndex = 0;
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
            // txtId
            // 
            txtId.Location = new Point(24, 138);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Id do Produto";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(500, 138);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PlaceholderText = "Quantidade";
            txtQuantidade.Size = new Size(151, 23);
            txtQuantidade.TabIndex = 3;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(846, 150);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btnFiltrar);
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(0, 238);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 100);
            panel2.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "", "Entrada", "Saída" });
            cmbTipo.Location = new Point(266, 138);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Todas", "Entrada", "Saída" });
            comboBox2.Location = new Point(24, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            // 
            // btnCadMovimentacao
            // 
            btnCadMovimentacao.Location = new Point(757, 143);
            btnCadMovimentacao.Name = "btnCadMovimentacao";
            btnCadMovimentacao.Size = new Size(75, 23);
            btnCadMovimentacao.TabIndex = 6;
            btnCadMovimentacao.Text = "Cadastrar";
            btnCadMovimentacao.UseVisualStyleBackColor = true;
            btnCadMovimentacao.Click += btnCadMovimentacao_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(302, 59);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // F_TelaMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 528);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "F_TelaMovimentacao";
            Text = "F_TelaMovimentacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnFiltrar;
        private ComboBox comboBox2;
    }
}