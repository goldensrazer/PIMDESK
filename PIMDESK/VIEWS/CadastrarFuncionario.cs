using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMDESK.VIEWS
{
    public partial class CadastrarFuncionario : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        private string login;
        public CadastrarFuncionario(string login)
        {
            InitializeComponent();
            label6.Text = login;
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            comando.Connection = sqlCon;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comando.Connection = sqlCon;
            sqlCon.Open();
            comando.CommandText = "INSERT INTO FUNCIONARIO (NOME, EMAIL, SENHA) VALUES('" + textNome.Text + "', '" + textEmail.Text + "', '" + textSenha.Text + "')";
            SqlDataReader dr = comando.ExecuteReader();
            sqlCon.Close();

            MessageBox.Show("Funcionario Cadastrado com Sucesso!", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }

}
