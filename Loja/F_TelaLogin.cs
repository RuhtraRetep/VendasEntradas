namespace Loja
{
    using MySql.Data.MySqlClient;
    public partial class F_TelaLogin : Form
    {
        public F_TelaLogin()
        {
            InitializeComponent();
        }

        private void Login()
        {
            string conexao = "Server=localhost;Database=loja;User=root;Password=;";
            string nomeParametro;
            try{
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string query = "Select nome,email,senha FROM usuario WHERE email = @email AND senha = @senha;";
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
					MySqlDataReader ler = cmd.ExecuteReader();

                    if (ler.HasRows)
                    {
                        if (ler.Read())
                        {
							nomeParametro = ler.GetString(0);
							F_TelaInicial f = new F_TelaInicial(nomeParametro);
							this.Hide();
							f.Show();
						}
                        
                    }

                    else
                    {
                        MessageBox.Show("E-mail ou senha inválidos");
                    }
                } 
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }
    }
}
