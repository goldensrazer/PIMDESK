using PIMDESK.VIEWS;
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


namespace PIM.VIEWS
{
    public partial class Controle : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;
        private string login1;


        public Controle()
        {
            InitializeComponent();
        }

        public Controle(string login)
        {
            InitializeComponent();
            label8.Text = login;
             login1 = login;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void acessar(string text1, string text2)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pagina1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Exibirbtn_Click(object sender, EventArgs e)
        {

        }

        private void Atbbtn_Click(object sender, EventArgs e)
        {
           
            sqlCon.Open();
            comando.CommandText = "UPDATE CHAMADO set ATRIBUICAO=(SELECT ATRIBUICAO.ID FROM ATRIBUICAO WHERE ATRIBUICAO.NOME='" + comboBox1.Text + "')WHERE CHAMADO.ID='"+ID.SelectedItem+ "'" ;
            comando.ExecuteNonQuery();
            sqlCon.Close();
            sqlCon.Open();
            comando.CommandText = "UPDATE CHAMADO set FUNCIONARIO=(SELECT FUNCIONARIO.ID FROM FUNCIONARIO WHERE FUNCIONARIO.EMAIL = '" + login1 + "')WHERE CHAMADO.ID='" + ID.SelectedItem + "'";
            comando.ExecuteNonQuery();
            sqlCon.Close();
            CarregarLista();
           
            
        }
        private void CarregarCombo()
        {
            comando.Connection = sqlCon;
            sqlCon.Open();
            comando.CommandText = "SELECT ATRIBUICAO.NOME FROM ATRIBUICAO ";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());


                }

            }
            sqlCon.Close();
        }
        private void CarregarLista()
        {
            comando.Connection = sqlCon;
            Conclusao.Items.Clear();
            Funcionario.Items.Clear();
            Cliente.Items.Clear();
            Descricao.Items.Clear();
            Titulo.Items.Clear();
            Grau.Items.Clear();
            ID.Items.Clear();
            sqlCon.Open();
            comando.CommandText = "SELECT DISTINCT CHAMADO.ID,GRAU_URGENCIA.NOME,CHAMADO.TITULO,CHAMADO.DESCRICAO,CLIENTE.NOME,FUNCIONARIO.NOME,ATRIBUICAO.NOME FROM CHAMADO INNER JOIN GRAU_URGENCIA ON CHAMADO.GRAU_URGENCIA = GRAU_URGENCIA.ID INNER JOIN CLIENTE ON CHAMADO.CLIENTE = CLIENTE.ID INNER JOIN FUNCIONARIO ON CHAMADO.FUNCIONARIO = FUNCIONARIO.ID INNER JOIN ATRIBUICAO ON CHAMADO.ATRIBUICAO = ATRIBUICAO.ID";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ID.Items.Add(dr[0].ToString());
                    Grau.Items.Add(dr[1].ToString());
                    Titulo.Items.Add(dr[2].ToString());
                    Descricao.Items.Add(dr[3].ToString());
                    Cliente.Items.Add(dr[4].ToString());
                    Funcionario.Items.Add(dr[5].ToString());
                    Conclusao.Items.Add(dr[6].ToString());

                }
                
            }
            sqlCon.Close();
           
        }
        private void CarregarListaFuncionario()
        {
            comando.Connection = sqlCon;
            listID.Items.Clear();
            listNome.Items.Clear();
            listEmail.Items.Clear();
         
            sqlCon.Open();
            comando.CommandText = "SELECT DISTINCT  FUNCIONARIO.ID,FUNCIONARIO.NOME,FUNCIONARIO.EMAIL,DEPARTAMENTO.NOME  FROM FUNCIONARIO INNER JOIN DEPARTAMENTO ON DEPARTAMENTO.ID = FUNCIONARIO.ID";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listID.Items.Add(dr[0].ToString());
                    listNome.Items.Add(dr[1].ToString());
                    listEmail.Items.Add(dr[2].ToString());
                    

                }

            }
            sqlCon.Close();

        }
        private void CarregarListaClientes()
        {
            comando.Connection = sqlCon;
            listIdCliente.Items.Clear();
            listNomeCliente.Items.Clear();
            listEmailCliente.Items.Clear();
            listDepartamentoCliente.Items.Clear();
            sqlCon.Open();
            comando.CommandText = "SELECT DISTINCT  CLIENTE.ID,CLIENTE.NOME,CLIENTE.EMAIL,DEPARTAMENTO.NOME FROM CLIENTE INNER JOIN DEPARTAMENTO ON CLIENTE.DEPARTAMENTO = DEPARTAMENTO.ID";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listIdCliente.Items.Add(dr[0].ToString());
                    listNomeCliente.Items.Add(dr[1].ToString());
                    listEmailCliente.Items.Add(dr[2].ToString());
                    listDepartamentoCliente.Items.Add(dr[3].ToString());

                }

            }
            sqlCon.Close();

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
            comando.CommandText = "SELECT DISTINCT GRAU_URGENCIA.NOME,CHAMADO.TITULO,CHAMADO.DESCRICAO,CLIENTE.EMAIL,ATRIBUICAO.NOME from CHAMADO INNER JOIN GRAU_URGENCIA ON GRAU_URGENCIA.ID = CHAMADO.GRAU_URGENCIA INNER JOIN CLIENTE ON CLIENTE.ID = CHAMADO.CLIENTE INNER JOIN FUNCIONARIO ON FUNCIONARIO.ID = CHAMADO.FUNCIONARIO INNER JOIN ATRIBUICAO ON CHAMADO.ATRIBUICAO = ATRIBUICAO.ID where FUNCIONARIO.EMAIL = '" + login1+"'";
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

        private void Controle_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            CarregarListaMeusChamados();
            CarregarListaClientes();
            CarregarListaFuncionario();
            CarregarLista();
            comando.Connection = sqlCon;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Grau_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                ID.SelectedIndex = l.SelectedIndex;
                Grau.SelectedIndex = l.SelectedIndex;
                Titulo.SelectedIndex = l.SelectedIndex;
                Descricao.SelectedIndex = l.SelectedIndex;
                Cliente.SelectedIndex = l.SelectedIndex;
                Funcionario.SelectedIndex = l.SelectedIndex;
                Conclusao.SelectedIndex = l.SelectedIndex;

                textBox1.Text = Titulo.SelectedItem.ToString();
                textBox2.Text = Conclusao.SelectedItem.ToString();
                txtID.Text = ID.SelectedItem.ToString();

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirChamado abrir = new AbrirChamado(login1);
            abrir.Show();
    
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void painelDeControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelControle abrir = new PainelControle(login1);
            abrir.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario abrir = new CadastrarFuncionario(login1);
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarCliente abrir = new CadastrarCliente(login1);
            abrir.Show();
        }

        private void MeusChamados_Click(object sender, EventArgs e)
        {

        }

        private void listDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MeuAtribuicao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChamadosPag_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void MeuEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            l.HorizontalScrollbar = true;
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

        private void MeuGrau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FuncionariosPag_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void listDepartamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientesPag_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void listDepartamentoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listEmailCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ContatosPag_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CarregarListaMeusChamados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            CarregarListaFuncionario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarregarListaClientes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CarregarLista();
        }

       
    }

   
}
