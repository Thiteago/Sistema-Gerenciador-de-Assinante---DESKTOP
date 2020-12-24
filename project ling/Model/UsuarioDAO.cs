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
        Usuario aux = new Usuario();

        public bool tem = false;
        public String mensagem = "";


        public IEnumerable<Usuario> MostrarUsuarioPendente()
        {
            List<Usuario> usuarios = new List<Usuario>();

            cmd.CommandText = "SELECT * FROM USUARIO_PENDENTE";

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        aux = new Usuario();
                        aux.Nome = dr["nomeCompleto"].ToString();
                        aux.ID1 = int.Parse(dr["ID_NOVO"].ToString());
                        aux.Nascimento = DateTime.Parse(dr["dataNascimento"].ToString());
                        aux.Email = dr["email"].ToString();
                        aux.Telefone = dr["telefone"].ToString();
                        aux.Rua = dr["rua"].ToString();
                        aux.Cidade = dr["cidade"].ToString();
                        aux.Estado = dr["estado"].ToString();
                        aux.UsuarioAcesso = dr["usuarioAcesso"].ToString();
                        aux.SenhaAcesso = dr["senhaAcesso"].ToString();
                        aux.Cargo = dr["Cargo"].ToString();
                        aux.Sexo1 = dr["Sexo"].ToString();

                        usuarios.Add(aux);
                    }
                    dr.Close();
                    conexao.desconectar();
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return usuarios;
        }

        public IEnumerable<Usuario> MostrarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            cmd.CommandText = "SELECT * FROM Usuario";

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        aux = new Usuario();
                        aux.Nome = dr["nomeCompleto"].ToString();
                        aux.Nascimento = DateTime.Parse(dr["dataNascimento"].ToString());
                        aux.Email = dr["email"].ToString();
                        aux.Telefone = dr["Telefone"].ToString();
                        aux.Rua = dr["rua"].ToString();
                        aux.Cidade = dr["cidade"].ToString();
                        aux.Estado = dr["estado"].ToString();
                        aux.UsuarioAcesso = dr["usuarioAcesso"].ToString();
                        aux.SenhaAcesso = dr["senhaAcesso"].ToString();
                        aux.Cargo = dr["Cargo"].ToString();

                        usuarios.Add(aux);


                    }
                    dr.Close();
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return usuarios;
        }

        public bool CheckPendente(string usuario)
        {
            bool tem1 = false;
            cmd.CommandText = "select * from USUARIO_PENDENTE where usuarioAcesso = @usuario";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@usuario", usuario);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                tem1 = true;
            }

            return tem1;
        }


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
