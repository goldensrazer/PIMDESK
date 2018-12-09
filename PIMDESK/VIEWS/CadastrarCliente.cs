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
    public partial class CadastrarCliente : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        private string login1;
        private int DpNumber;

        public CadastrarCliente(string login1)
        {
            InitializeComponent();
            label2.Text = login1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarLista()
            {
                comando.Connection = sqlCon;
                cmbDepartamento.Items.Clear();
           
                sqlCon.Open();
                comando.CommandText = "select NOME from DEPARTAMENTO";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cmbDepartamento.Items.Add(dr[0].ToString());


                    }
                }
           sqlCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            comando.Connection = sqlCon;
            sqlCon.Open();
            comando.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL, SENHA, DEPARTAMENTO) VALUES('" + textNome.Text + "', '" + textEmail.Text + "', '" + textSenha.Text + "',(SELECT DEPARTAMENTO.ID FROM DEPARTAMENTO WHERE DEPARTAMENTO.NOME = '" + cmbDepartamento.Text + "'))";
            SqlDataReader dr = comando.ExecuteReader();
            sqlCon.Close();

            MessageBox.Show("Funcionario Cadastrado com Sucesso!", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            comando.Connection = sqlCon;
            CarregarLista();
        }
    }
}
