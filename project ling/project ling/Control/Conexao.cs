using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Construtor

        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-O99010H\SQLEXPRESS;Initial Catalog=BDLP2;Integrated Security=True";
        }
        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection RetornarConexao()
        {
            return con;
        }

    }
}
