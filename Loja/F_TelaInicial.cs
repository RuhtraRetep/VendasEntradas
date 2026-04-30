using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loja
{
    public partial class F_TelaInicial : Form
    {
        string salvarParametro;
        public F_TelaInicial(string nomeParametro)
        {
            InitializeComponent();
            lblNome.Text = nomeParametro;
            salvarParametro = nomeParametro;
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            F_TelaCadUsuario f = new F_TelaCadUsuario(salvarParametro);
            this.Hide();
            f.Show();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {

            F_TelaCadProduto f = new F_TelaCadProduto(salvarParametro);
            this.Hide();
            f.Show();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            F_TelaMovimentacao f = new F_TelaMovimentacao(salvarParametro);
            this.Hide();
            f.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            F_TelaLogin f = new F_TelaLogin();
            this.Hide();
            f.Show();
        }
    }
}
