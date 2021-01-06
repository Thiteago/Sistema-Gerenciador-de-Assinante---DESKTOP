using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        


        public bool CheckIgual(string email, string usuario, int ID)
        {
            bool pode = false;

            cmd.CommandText = "Select * from Usuario WHERE email = @email OR usuarioAcesso = @user";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@user", usuario);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if(int.Parse(dr["ID"].ToString()) == ID)
                    {
                        pode = true;
                    }
                    else if(int.Parse(dr["ID"].ToString()) != ID)
                    {
                        pode = false;
                    }
                }
            }
            conexao.desconectar();
            dr.Close();

            return pode;
        }

        public bool AlterarUsuario(int ID, string nome, DateTime nascimento, string email, string telefone, string rua, string cidade, string estado, string cargo, string sexo, string usuario, string senha, string nivel)
        {
            bool foi = false;

            cmd.CommandText = "UPDATE Usuario  SET nomeCompleto = @Nome, dataNascimento = @data, email = @email, telefone = @tel, rua = @rua, cidade = @city, estado = @state, Cargo = @cargo, Sexo = @sex," +
                              "usuarioAcesso = @user, senhaAcesso = @senha, NIVELACESSO = @nivel WHERE ID = @id";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@data", nascimento);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tel", telefone);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@city", cidade);
            cmd.Parameters.AddWithValue("@state", estado);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@sex", sexo);
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            cmd.Parameters.AddWithValue("@id", ID);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                conexao.desconectar();
                dr.Close();
                foi = true;
            }
            catch (Exception )
            {
                MessageBox.Show("Erro banco de dados");
            }


            return foi;
        }

        public IEnumerable<Usuario>CarregarDados(string nome, string cargo, int ID)
        {
            List<Usuario> user = new List<Usuario>();

            cmd.CommandText = "select * from Usuario where ID = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", ID);

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
                    aux.Telefone = dr["telefone"].ToString();
                    aux.Rua = dr["rua"].ToString();
                    aux.Cidade = dr["cidade"].ToString();
                    aux.Estado = dr["estado"].ToString();
                    aux.UsuarioAcesso = dr["usuarioAcesso"].ToString();
                    aux.SenhaAcesso = dr["senhaAcesso"].ToString();
                    aux.Cargo = dr["Cargo"].ToString();
                    aux.Sexo1 = dr["Sexo"].ToString();
                    aux.ID1 = int.Parse(dr["ID"].ToString());

                    user.Add(aux);
                }
                dr.Close();
                conexao.desconectar();
            }

            return user;
        }

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
                        aux.ID1 = int.Parse(dr["ID"].ToString());

                        usuarios.Add(aux);
                    }
                    dr.Close();
                    conexao.desconectar();
                }
            }
            catch (SqlException )
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
                        aux.ID1 = int.Parse(dr["ID"].ToString());
                        aux.NivelDeAcesso1 = dr["NIVELACESSO"].ToString();

                        usuarios.Add(aux);


                    }
                    dr.Close();
                }
            }
            catch (SqlException )
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
