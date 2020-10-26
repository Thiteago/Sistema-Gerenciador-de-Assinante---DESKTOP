using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project_ling.Model;

namespace project_ling
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        Usuario usuario = new Usuario();
        Usuario aux = new Usuario();
        public String mensagem = "";

        //Método para cadastro do cliente

        public Cadastro(string nome, string dataNascimento, string email, string telefone, 
                        string rua, string cidade, string estado, string nomeAcesso, string senha, string cargo, string sexo)
        {
            //Comando SQL - Insert, update, delete
            cmd.CommandText = "insert into Usuario (nomeCompleto, dataNascimento, email, " +
                              "telefone, rua, cidade, estado, usuarioAcesso, senhaAcesso, Cargo,Sexo) " +
                              "values( @nomeCompleto, @dataNascimento, @email, " +
                              "@telefone, @rua, @cidade, @estado, @usuarioAcesso, @senhaAcesso, @cargo, @sexo)";
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
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@sexo", sexo);
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
                this.mensagem = "Cadastrado com Sucesso!";
            }

            catch (SqlException ex)
            {
                this.mensagem = ex.ToString();
            }



        }
    }
}
