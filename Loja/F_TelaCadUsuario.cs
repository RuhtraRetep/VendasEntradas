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
        public F_TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void Cadastrar()
        {
			string conexao = "Server=localhost;Database=Loja;User=root;Password=;";

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
    }
}
