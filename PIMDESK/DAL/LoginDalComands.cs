using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.DAL
{   

    class LoginDalComands
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            
            cmd.CommandText = "SELECT FUNCIONARIO.EMAIL,FUNCIONARIO.SENHA FROM FUNCIONARIO WHERE FUNCIONARIO.EMAIL=@login AND FUNCIONARIO.SENHA=@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro ";
            }
            return tem;
        }

        public bool verificarLogin2(String login, String senha)
        {

            cmd.CommandText = "SELECT CLIENTE.EMAIL,CLIENTE.SENHA FROM CLIENTE WHERE CLIENTE.EMAIL=@login AND CLIENTE.SENHA=@senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro ";
            }
            return tem;
        }
    }
}
