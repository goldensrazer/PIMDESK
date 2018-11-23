using PIMDESK.MODELS;
using System;
using System.Windows.Forms;

namespace PIMDESK
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
            Controler contr = new Controler();
            contr.acessar(txtEmail.Text,txtPass.Text);
            if (contr.mensagem.Equals("")) { 
                if (contr.tem)
                {
                    MessageBox.Show("Logado com Sucesso!","Entrando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Login logado = new Login();
                    logado.Show();
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
    }
}
