using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja
{
    public partial class F_TelaCadUsuario : Form
    {
        string salvarParametro;
        string conexao = "Server=localhost;Database=Loja;User=root;Password=;";
        public F_TelaCadUsuario(string loginParametro)
        {
            InitializeComponent();
            salvarParametro = loginParametro;
        }

        private void Visualizar()
        {
            string query = "Select * FROM usuario;";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Cadastrar()
        {


            try
            {
                string query = "INSERT INTO usuario (nome,email,senha) Values (@nome,@email,@senha);";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário Cadastrado com sucesso");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void btnCad_Click(object sender, EventArgs e)
        {
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
            Visualizar();
        }
    }
}
