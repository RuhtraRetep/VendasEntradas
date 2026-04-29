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

		public F_TelaInicial(string nomeParametro)
        {
            InitializeComponent();
            lblNome.Text = nomeParametro;
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            F_TelaCadUsuario f = new F_TelaCadUsuario();
            this.Hide();
            f.Show();
        }

        private void btnCadProdutos_Click(object sender, EventArgs e)
        {
            
            F_TelaCadProduto f = new F_TelaCadProduto();
            this.Hide();
            f.Show();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
			string nomeParametro = lblNome.Text;
			F_TelaMovimentacao f = new F_TelaMovimentacao(nomeParametro);
            this.Hide();
            f.Show();
        }
    }
}
