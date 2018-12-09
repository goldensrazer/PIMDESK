using PIM.VIEWS;
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
    public partial class AbrirChamadoCliente : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader drr;
        private string login;
        public AbrirChamadoCliente(string login)
        {
            InitializeComponent();
            label5.Text = login;
        }

        private void AbrirChamadoCliente_Load(object sender, EventArgs e)
        {
            CarregarLista();
            comando.Connection = sqlCon;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            sqlCon.Open();
            comando.CommandText = "INSERT INTO CHAMADO (DEPARTAMENTO, GRAU_URGENCIA, TITULO, DESCRICAO, CLIENTE, FUNCIONARIO, CONCLUSAO,ATRIBUICAO) VALUES((SELECT DEPARTAMENTO.ID FROM DEPARTAMENTO WHERE DEPARTAMENTO.NOME = '" + cmbDepartamento.Text + "'),(SELECT GRAU_URGENCIA.ID FROM GRAU_URGENCIA WHERE GRAU_URGENCIA.NOME = '" + cmbUrgencia.Text + "'), '" + txtTitulo.Text + "', '" + txtDescricao.Text + "', (SELECT CLIENTE.ID FROM CLIENTE WHERE CLIENTE.NOME = '" + cmbCliente.Text + "'), (SELECT FUNCIONARIO.ID FROM FUNCIONARIO WHERE FUNCIONARIO.NOME = '" + cmbFuncionario.Text + "'), NULL,1)";
            SqlDataReader dr = comando.ExecuteReader();
            sqlCon.Close();
            MessageBox.Show("Chamado aberto com sucesso", "Obrigado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
        private void CarregarLista()
        {
            comando.Connection = sqlCon;
            cmbDepartamento.Items.Clear();
            cmbUrgencia.Items.Clear();
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
            sqlCon.Open();
            comando.CommandText = " select NOME from GRAU_URGENCIA";
            drr = comando.ExecuteReader();
            if (drr.HasRows)
            {
                while (drr.Read())
                {
                    cmbUrgencia.Items.Add(drr[0].ToString());


                }
            }
            sqlCon.Close();
            sqlCon.Open();
            comando.CommandText = " select NOME from CLIENTE";
            drr = comando.ExecuteReader();
            if (drr.HasRows)
            {
                while (drr.Read())
                {
                    cmbCliente.Items.Add(drr[0].ToString());


                }
            }
            sqlCon.Close();
            sqlCon.Open();
            comando.CommandText = " select NOME from FUNCIONARIO";
            drr = comando.ExecuteReader();
            if (drr.HasRows)
            {
                while (drr.Read())
                {
                    cmbFuncionario.Items.Add(drr[0].ToString());


                }
            }
            sqlCon.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PainelCliente Controle = new PainelCliente();
            Controle.Show();
            this.Close();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
