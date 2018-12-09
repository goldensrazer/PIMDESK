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
    public partial class PainelCliente : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        private string login1;

        public PainelCliente()
        {
            InitializeComponent();
            CarregarListaMeusChamados();

        }
        public PainelCliente(string login)
        {
            InitializeComponent();
            label2.Text = login;
            login1 = login;
            CarregarListaMeusChamados();
        }

        private void PainelCliente_Load(object sender, EventArgs e)
        {
            CarregarListaMeusChamados();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PainelControle abrir = new PainelControle(login1);
            abrir.Show();
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            CarregarListaMeusChamados();
            AbrirChamadoCliente abrir = new AbrirChamadoCliente(login1);
            abrir.Show();
        }

        private void MeusChamados_Click(object sender, EventArgs e)
        {

        }
        private void CarregarListaMeusChamados()
        {
            comando.Connection = sqlCon;
            MeuGrau.Items.Clear();
            MeuTitulo.Items.Clear();
            MeuDescricao.Items.Clear();
            MeuEmail.Items.Clear();
            MeuAtribuicao.Items.Clear();
            sqlCon.Open();
            comando.CommandText = "SELECT DISTINCT GRAU_URGENCIA.NOME,CHAMADO.TITULO,CHAMADO.DESCRICAO,FUNCIONARIO.EMAIL,ATRIBUICAO.NOME from CHAMADO INNER JOIN GRAU_URGENCIA ON GRAU_URGENCIA.ID = CHAMADO.GRAU_URGENCIA INNER JOIN CLIENTE ON CLIENTE.ID = CHAMADO.CLIENTE INNER JOIN FUNCIONARIO ON FUNCIONARIO.ID = CHAMADO.FUNCIONARIO INNER JOIN ATRIBUICAO ON ATRIBUICAO.ID = CHAMADO.ATRIBUICAO where CLIENTE.EMAIL = '"+login1+"'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    MeuGrau.Items.Add(dr[0].ToString());
                    MeuTitulo.Items.Add(dr[1].ToString());
                    MeuDescricao.Items.Add(dr[2].ToString());
                    MeuEmail.Items.Add(dr[3].ToString());
                    MeuAtribuicao.Items.Add(dr[4].ToString());

                }

            }
            sqlCon.Close();

        }

        private void Carregar_Click(object sender, EventArgs e)
        {
            CarregarListaMeusChamados();
        }

        private void MeuDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            l.HorizontalScrollbar = true;
        }

        private void MeuTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            l.HorizontalScrollbar = true;
        }

        private void MeuEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            l.HorizontalScrollbar = true;
        }
    }
}
