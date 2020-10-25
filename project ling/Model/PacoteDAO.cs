using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project_ling.Control;

namespace project_ling.Model
{
    public class PacoteDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public String mensagem = "";
        Pacotes aux = new Pacotes();

        public void DeletarPacote(int ID)
        {
            cmd.CommandText = "UPDATE Assinante SET Plano = NULL WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
        }


        public IEnumerable<Pacotes> MostrarPacotes(int ID)
        {
            List<Pacotes> pac = new List<Pacotes>();
            cmd.CommandText = "SELECT Plano FROM Assinante WHERE ID = @id ";
            cmd.Parameters.AddWithValue("@id", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aux.Nome_pacote = dr["Plano"].ToString();
                    pac.Add(aux);
                }
                dr.Close();
            }

            return pac;
        }

        public void AdicionarPacote(int ID, List<string> Pacote) {

            string x = Pacote[0];

            cmd.CommandText = "UPDATE Assinante SET Plano = @pct WHERE ID = @id";
            cmd.Parameters.AddWithValue("@pct", x);
            cmd.Parameters.AddWithValue("@id", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
        }
    }
}
