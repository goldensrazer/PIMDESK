using PIM.MODELS;
using PIM.VIEWS;
using PIMDESK.VIEWS;
using System;
using System.Windows.Forms;

namespace PIM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
           
            if(cmbTipo.Text == "Funcionario") { 
                Controler contr = new Controler();
                contr.acessar(txtEmail.Text,txtPass.Text);
                if (contr.mensagem.Equals("")) { 
                    if (contr.tem)
                    {
                        string login = txtEmail.Text;
                        MessageBox.Show("Logado com Sucesso!","Entrando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                         Controle controle = new Controle(login);
                            controle.Show();
                            Hide();
          
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorreto!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                }else
                {
                    MessageBox.Show(contr.mensagem);
                }
            }
            else if(cmbTipo.Text == "Cliente")
            {
                Controler contr = new Controler();
                contr.acessar2(txtEmail.Text, txtPass.Text);
                if (contr.mensagem.Equals(""))
                {
                    if (contr.tem)
                    {
                        string login = txtEmail.Text;
                        MessageBox.Show("Logado com Sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PainelCliente controlee = new PainelCliente(login);
                        controlee.Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("Email ou senha incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show(contr.mensagem);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
