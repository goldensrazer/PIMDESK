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
    public partial class PainelControle : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        private string login1;

        public PainelControle(string login)
        {
            InitializeComponent();
            txtEmail.Text = login;
            login1 = login;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            if(cmbtipo.Text == "Funcionário") { 
            comando.Connection = sqlCon;
            sqlCon.Open();
            comando.CommandText = "UPDATE FUNCIONARIO SET FUNCIONARIO.SENHA='"+ txtSenha.Text + "' WHERE FUNCIONARIO.EMAIL='" + login1+"'";
            SqlDataReader dr = comando.ExecuteReader();
            sqlCon.Close();
            MessageBox.Show("Senha trocada com sucesso!", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            }else if(cmbtipo.Text == "Cliente")
            {
                comando.Connection = sqlCon;
                sqlCon.Open();
                comando.CommandText = "UPDATE CLIENTE SET CLIENTE.SENHA='" + txtSenha.Text + "' WHERE CLIENTE.EMAIL='" + login1 + "'";
                SqlDataReader dr = comando.ExecuteReader();
                sqlCon.Close();
                MessageBox.Show("Senha trocada com sucesso!", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
        }

        private void PainelControle_Load(object sender, EventArgs e)
        {

        }
    }
}
