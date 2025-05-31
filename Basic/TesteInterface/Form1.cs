using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesteInterface
{
    public partial class Form1 : Form
    {
        // string de conexão (ajuste o nome do banco se necessário)
        string conexao = "server=localhost;uid=root;pwd=;database=exemplo;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    this.BackColor = Color.LightGreen; // muda a cor da tela ao conectar
                    MessageBox.Show("Conexão bem-sucedida com o banco de dados!");
                }
            }
            catch (Exception ex)
            {
                this.BackColor = Color.LightCoral; // vermelho claro para erro
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }
    }
}
