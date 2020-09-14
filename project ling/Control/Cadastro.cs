using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String msg = "";
        public Cadastro(string nome, string dataNascimento, string email, string telefone, 
                        string rua, string cidade, string estado, string nomeAcesso, string senha)
        {
            //Comando SQL - Insert, update, delete
            cmd.CommandText = "insert into Usuario (nomeCompleto, dataNascimento, email, " +
                              "telefone, rua, cidade, estado, usuarioAcesso, senhaAcesso) " +
                              "values( @nomeCompleto, @dataNascimento, @email, " +
                              "@telefone, @rua, @cidade, @estado, @usuarioAcesso, @senhaAcesso)";
            //Parametros
            cmd.Parameters.AddWithValue("@nomeCompleto", nome);
            cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@usuarioAcesso", nomeAcesso);
            cmd.Parameters.AddWithValue("@senhaAcesso", senha);
            //Conectar Banco
            try
            {
                //Conectar Banco
                cmd.Connection = conexao.conectar();
                // executar o banco
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem
                this.msg = "Cadastrado com Sucesso!";
            }

            catch (SqlException ex)
            {
                this.msg = ex.ToString();
            }



        }
    }
}
