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
    public partial class F_TelaMovimentacao : Form
    {
        string conexao = "Server=localhost;Database=loja;User=root;Password=;";
        string salvarParametro;
        public F_TelaMovimentacao(string nomeParametro)
        {
            InitializeComponent();
            salvarParametro = nomeParametro;
        }

        private void Cadastrar()
        {
            string queryCad = "INSERT INTO movimentacao (id_usuario, id_produto, tipo, quantidade) " +
                "Values (@idUsuario, @idProduto, @tipo, @qtd);";

            string queryUsuario = "Select id From usuario WHERE nome = @nome";
            string idUser;



			using (MySqlConnection conn = new MySqlConnection(conexao))
            {
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(queryUsuario, conn);
                cmd.Parameters.AddWithValue("@nome", salvarParametro);
                var ler = cmd.ExecuteReader();
                if (ler.Read())
                {
                    try 
                    {
						idUser = ler["id"].ToString();
                        conn.Close();
                        conn.Open();
						MySqlCommand cmd2 = new MySqlCommand(queryCad, conn);
						cmd2.Parameters.AddWithValue("@idUsuario", idUser);
						cmd2.Parameters.AddWithValue("@idProduto", txtId.Text);
						cmd2.Parameters.AddWithValue("@tipo", cmbTipo.Text);
						cmd2.Parameters.AddWithValue("@qtd", txtQuantidade.Text);
						cmd2.ExecuteNonQuery();
					}
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    MessageBox.Show("Deu certo");
                   
				}

                else { MessageBox.Show("Deu ruim");  return; }

            }
        }
        private void btnCadMovimentacao_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
    }
}
