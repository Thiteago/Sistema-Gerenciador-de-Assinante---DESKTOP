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


        public int CheckAlteracao(string email, string nomeAcesso, int ID)
        {
            int mesmo = 0;
            int num;

            //////////////////////////////////////////////////////////////////////////////
            //Verifica se Email atual é igual ao ja cadastrado
            //////////////////////////////////////////////////////////////////////////////
            
            cmd.CommandText = "select * from Usuario Where email = @email AND id = @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@email", email);
            cmd.Parameters.Add("@ID", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                mesmo = 1;
            }

            dr.Close();
            conexao.desconectar();
            //////////////////////////////////////////////////////////////////////////////
            //Verifica se Usuario atual é igual ao ja cadastrado
            //////////////////////////////////////////////////////////////////////////////
            
            cmd.CommandText = "select * from Usuario Where usuarioAcesso = @nome AND id = @ID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@nome", nomeAcesso);
            cmd.Parameters.Add("@ID", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                mesmo += 2;
            }
            dr.Close();
            conexao.desconectar();

            //////////////////////////////////////////////////////////////////////////////
            //Verifica se o Usuário alterado já existe
            //////////////////////////////////////////////////////////////////////////////
            if (mesmo == 1)
            {
                cmd.CommandText = "SELECT COUNT(*) usuarioAcesso FROM Usuario WHERE usuarioAcesso = @nomeAcesso";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@nomeAcesso", nomeAcesso);
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                num = 0;
                num = dr.GetInt32(0);
                dr.Close();
                conexao.desconectar();
                if (num > 0)
                {
                    mesmo += 1;
                    return mesmo;
                }
                return mesmo;
             //////////////////////////////////////////////////////////////////////////////
             //Verifica se o Email alterado já existe
             //////////////////////////////////////////////////////////////////////////////
            }
            else if(mesmo == 2)
            {
                cmd.CommandText = "SELECT COUNT(*) email FROM Usuario WHERE email = @email";
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@email", email);
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                num = 0;
                num = dr.GetInt32(0);
                dr.Close();
                conexao.desconectar();
                if (num > 0)
                {
                    mesmo += 1;
                    return mesmo;
                }
                return mesmo-1;
                //////////////////////////////////////////////////////////////////////////////
                //Neste caso todos os dados podem ser inseridos
                //////////////////////////////////////////////////////////////////////////////
            }
            else if(mesmo == 3)
            {
                mensagem = "Cadastro Alterado com Sucesso";
                return mesmo - 2;
            }

            return mesmo;
        }


        public int CheckCadastro(string email, string nomeAcesso)
        {
            int msg = 0;
            int num;

            //////////////////////////////////////////////////////////////////////////////
            //Verifica se o email inserido já foi utilizado por outro usuário
            //////////////////////////////////////////////////////////////////////////////
            
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

            //////////////////////////////////////////////////////////////////////////////
            //Verifica se o Usuário inserido já foi utilizado por outro usuário
            //////////////////////////////////////////////////////////////////////////////
            
            
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

        
        
        //////////////////////////////////////////////////////////////////////////////
        //Insere os dados do cadastro nos usuários pendentes
        //////////////////////////////////////////////////////////////////////////////
        public void SolicitarCadastro(string nome, string dataNascimento, string email, string telefone,
                        string rua, string cidade, string estado, string nomeAcesso, string senha, string cargo, string sexo)
        {
            cmd.CommandText = "insert into USUARIO_PENDENTE (nomeCompleto, dataNascimento, email, " +
                              "telefone, rua, cidade, estado, usuarioAcesso, senhaAcesso, Cargo, Sexo) " +
                              "values( @nomeCompleto, @dataNascimento, @email, " +
                              "@telefone, @rua, @cidade, @estado, @usuarioAcesso, @senhaAcesso, @cargo, @sexo)";

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

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            conexao.desconectar();
            dr.Close();

            this.mensagem = "Sua solicitação foi enviada ao Administrador!";
        }

        
        //////////////////////////////////////////////////////////////////////////////
        //Remove o cadastro pendente do banco de dados
        //////////////////////////////////////////////////////////////////////////////        
        
        public void RecusarCadastro(string email)
        {
            cmd.CommandText = "Delete From USUARIO_PENDENTE WHERE email = @email";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@email", email);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            conexao.desconectar();
            dr.Close();

            this.mensagem = "Cadastro Recusado com sucesso!";
        }

        
        
        //////////////////////////////////////////////////////////////////////////////
        //Remove cadastro do usuário pendente e o efetiva comno usuário no sistema.
        //////////////////////////////////////////////////////////////////////////////        
        
        public void Cadastrar(string nome, DateTime dataNascimento, string email, string telefone,
                        string rua, string cidade, string estado, string nomeAcesso, string senha, string cargo, string sexo, string NiveldeAcesso)
        {
            //Comando SQL - Insert, update, delete
            cmd.CommandText = "insert into Usuario (nomeCompleto, dataNascimento, email, " +
                              "telefone, rua, cidade, estado, usuarioAcesso, senhaAcesso, Cargo, Sexo, NIVELACESSO) " +
                              "values( @nomeCompleto, @dataNascimento, @email, " +
                              "@telefone, @rua, @cidade, @estado, @usuarioAcesso, @senhaAcesso, @cargo, @sexo, @nivel)";
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
            cmd.Parameters.AddWithValue("@nivel", NiveldeAcesso);

            //Conectar Banco
            cmd.Connection = conexao.conectar();
            // executar o banco
            dr = cmd.ExecuteReader();
            //desconectar
            conexao.desconectar();
            dr.Close();
            //mostrar mensagem
            this.mensagem = "Cadastrado com Sucesso!";


            cmd.CommandText = "Delete From Usuario_Pendente WHERE email = @email";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@email", email);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            conexao.desconectar();
            dr.Close();


            
          
        }



        }
    }

