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
        SqlDataReader dr;

        //Método para cadastro do cliente


        public int CheckCadastro(string email, string nomeAcesso)
        {
            int msg = 0;
            int num;

            cmd.CommandText = "SELECT COUNT(*) email FROM Usuario WHERE email = @email";
            cmd.Parameters.AddWithValue("@email", email);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            dr.Read();
            num = dr.GetInt32(0);
            dr.Close();
            conexao.desconectar();

            if (num > 0)
            {
                msg = 1;
            }

            cmd.CommandText = "SELECT COUNT(*) usuarioAcesso FROM Usuario WHERE usuarioAcesso = @nomeAcesso";
            cmd.Parameters.AddWithValue("@nomeAcesso", nomeAcesso);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            dr.Read();
            num = 0;
            num = dr.GetInt32(0);
            dr.Close();
            conexao.desconectar();

            if(num > 0)
            {
                msg += 2;
            }


            return msg;
        }


        public void Cadastrar(string nome, string dataNascimento, string email, string telefone,
                        string rua, string cidade, string estado, string nomeAcesso, string senha, string cargo, string sexo)
        {
            //Comando SQL - Insert, update, delete
            cmd.CommandText = "insert into Usuario (nomeCompleto, dataNascimento, email, " +
                              "telefone, rua, cidade, estado, usuarioAcesso, senhaAcesso, Cargo, Sexo) " +
                              "values( @nomeCompleto, @dataNascimento, @email, " +
                              "@telefone, @rua, @cidade, @estado, @usuarioAcesso, @senhaAcesso, @cargo, @sexo)";
            //Parametros
            cmd.Parameters.Clear();
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
            cmd.Connection = conexao.conectar();
            // executar o banco
            dr = cmd.ExecuteReader();
            //desconectar
            conexao.desconectar();

            dr.Close();
            //mostrar mensagem
            this.mensagem = "Cadastrado com Sucesso!";
        }



        }
    }

