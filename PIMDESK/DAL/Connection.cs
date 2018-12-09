using System.Data.SqlClient;

namespace PIM.DAL
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();
        public Connection()
        {
            con.ConnectionString = @"Data Source=DESKTOP-K7O7SD3\SQLEXPRESS;Initial Catalog=PIM;Integrated Security=True";

        }

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
