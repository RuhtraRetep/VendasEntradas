using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Loja
{
    public partial class F_TelaCadProduto : Form
    {
        string conexao = "Server=localhost;Database=loja;User=root;Password=;";
        string salvarParametro;
        public F_TelaCadProduto(string nomeParametro)
        {
            salvarParametro = nomeParametro;
            InitializeComponent();
        }

        private void Cadastrar()
        {

            try
            {
                string query = "INSERT INTO produto (nome,estoque_atual,estoque_minimo) Values(@nome, @qtdAtual, @qtdMinimo);";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@qtdAtual", txtQuantidadeAtual.Text);
                    cmd.Parameters.AddWithValue("@qtdMinimo", txtQuantidadeMinima.Text);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Produto Cadastrado!!!!");
            AtualizarDGV();
        }

        private void AtualizarDGV()
        {
            string query = "Select * From produto";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProdutos.DataSource = dt;
            }
        }
        private void btnCad_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQuantidadeAtual.Text) < Convert.ToInt32(txtQuantidadeMinima.Text))
            {
                MessageBox.Show("A quantidade atual não pode ser menor que a quantidade mínima");
                return;
            }
            Cadastrar();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            F_TelaInicial f = new F_TelaInicial(salvarParametro);
            this.Hide();
            f.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
