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
            string queryCadSaida = "INSERT INTO movimentacao (id_usuario, id_produto, tipo, quantidade) " +
                "Values (@idUsuario, @idProduto, @tipo, @qtd);UPDATE produto " +
                "SET estoque_atual = estoque_atual - @qtd " +
                "WHERE id = @idProduto;";

            string queryCadEntrada = "INSERT INTO movimentacao (id_usuario, id_produto, tipo, quantidade) " +
                "Values (@idUsuario, @idProduto, @tipo, @qtd);UPDATE produto " +
                "SET estoque_atual = estoque_atual + @qtd " +
                "WHERE id = @idProduto;";

            string queryUsuario = "Select id From usuario WHERE nome = @nome";

            string queryVerificarQtd = "Select estoque_atual From produto WHERE id = @id";

            string idUser;
            int quantidadeBD = 0;



            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                MySqlCommand cmdPegarIdUser = new MySqlCommand(queryUsuario, conn);
                cmdPegarIdUser.Parameters.AddWithValue("@nome", salvarParametro);
                var ler = cmdPegarIdUser.ExecuteReader();
                if (ler.Read())
                {
                    try
                    {
                        idUser = ler["id"].ToString();
                        conn.Close(); // Pegou o id do usuário para cadastrar quem fez a movimentação

                        if (cmbTipo.Text == "Saída")
                        {
                            MySqlCommand cmdVerificar = new MySqlCommand(queryVerificarQtd, conn);
							conn.Open();
							cmdVerificar.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                            var verificarQtd = cmdVerificar.ExecuteReader();
                           
                            if (verificarQtd.Read())
                            {
                                quantidadeBD = Convert.ToInt32(verificarQtd["estoque_atual"]?.ToString() ?? "-1");

                                if (quantidadeBD == -1)
                                {
                                    MessageBox.Show("Valor veio nulo do Banco");
                                    return;
                                }
								if (quantidadeBD >= Convert.ToInt32(txtQuantidade.Text))
                                {
                                    conn.Close();
                                    conn.Open();
                                    MySqlCommand cmd2 = new MySqlCommand(queryCadSaida, conn);
                                    cmd2.Parameters.AddWithValue("@idUsuario", idUser);
                                    cmd2.Parameters.AddWithValue("@idProduto", txtId.Text);
                                    cmd2.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                                    cmd2.Parameters.AddWithValue("@qtd", txtQuantidade.Text);
                                    cmd2.ExecuteNonQuery();
                                    conn.Close();
                                    PreencherDataGrid();
                                }

                                else
                                {
                                    MessageBox.Show("Não foi possível realizar a venda, não há essa quantidade em estoque");
                                }
                            }

                            else
                            {
                                MessageBox.Show("Produto não encontrado");
                                return;
                            }


                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            MySqlCommand cmd2 = new MySqlCommand(queryCadEntrada, conn);
                            cmd2.Parameters.AddWithValue("@idUsuario", idUser);
                            cmd2.Parameters.AddWithValue("@idProduto", txtId.Text);
                            cmd2.Parameters.AddWithValue("@tipo", cmbTipo.Text);
                            cmd2.Parameters.AddWithValue("@qtd", txtQuantidade.Text);
                            cmd2.ExecuteNonQuery();
                            conn.Close();
                            PreencherDataGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    MessageBox.Show("Deu certo");

                }

                else { MessageBox.Show("Deu ruim"); return; }

            }
        }
        private void Filtrar()
        {
            MySqlConnection conn = new MySqlConnection(conexao);
            if (string.IsNullOrEmpty(cmbFiltrar.Text))
            {
                MessageBox.Show("Escolha uma das opções de filtro");
                return;
            }
            if (cmbFiltrar.Text == "Todas")
            {
                string query = "Select m.id, u.nome AS Nome_User, p.nome AS Nome_Produto, m.tipo, m.quantidade, m.data_movimentacao From movimentacao AS m" +
                    " INNER JOIN produto AS p ON m.id_produto = p.id" +
					" INNER JOIN usuario AS u ON m.id_usuario = u.id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMovimentacao.DataSource = dt;
                }
                return;
            }


            try
            {
                string query = "Select m.id, u.nome AS Nome_User, p.nome AS Nome_Produto, m.tipo, m.quantidade, m.data_movimentacao From movimentacao AS m" +
                    " INNER JOIN produto AS p ON m.id_produto = p.id" +
                    " INNER JOIN usuario AS u ON m.id_usuario = u.id" +
					 " WHERE tipo = @tipo";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipo", cmbFiltrar.Text);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMovimentacao.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PreencherDataGrid()
        {
            string query = "Select id_usuario, id_produto, tipo, quantidade From movimentacao";
            MySqlConnection conn = new MySqlConnection(conexao);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMovimentacao.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCadMovimentacao_Click(object sender, EventArgs e)
        {
            Cadastrar();
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            F_TelaInicial f = new F_TelaInicial(salvarParametro);
            this.Hide();
            f.Show();
        }
    }
}
