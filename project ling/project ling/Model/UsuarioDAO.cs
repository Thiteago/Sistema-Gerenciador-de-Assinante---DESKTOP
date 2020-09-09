using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling.Model
{
    class UsuarioDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool tem = false;
        public String mensagem = "";

        public bool verificarLogin(string usuario, string senha)
        {
            //comandos sql para verificar se há cadastro no banco
            cmd.CommandText = "select * from Usuario where usuarioAcesso = @usuario and senhaAcesso = @senha";
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
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
