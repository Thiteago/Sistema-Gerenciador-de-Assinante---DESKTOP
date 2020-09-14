using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling.Model
{
    class AssinanteDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public String tem;
        public String mensagem = "";

        public string pesquisa(string categoria, string busca)
        {
            //comandos sql para verificar se há cadastro no banco
            if(categoria == "Nome")
            {
                cmd.CommandText = "select * from Assinante where Nome = @Nome";
                cmd.Parameters.AddWithValue("@Nome", busca);
            }
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = busca;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return tem;
        }
    }
}
