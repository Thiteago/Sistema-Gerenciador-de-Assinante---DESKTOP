using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling
{
    public class CadastroAssinante
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String msg = "";
        
        //Método para o cadastro do Assinante
        
        public CadastroAssinante(string nome, string cpf, string rua, string bairro, string cidade, string estado, string telefone,
            string email, DateTime datanascimento,string profissao,string EstadoCivil, string sexo,string numero, string tipoRua, string complemento)
        {

            string situacao = "Ativo";
            //Comando SQL - Insert, update, delete
            cmd.CommandText = "insert into Assinante (Nome, CPF, Bairro, Cidade, Estado, Telefone, Email, Rua, datanascimento, Profissao, EstadoCivil, Sexo, NumeroRua, TipoRua, Complemento, situation)" +
                              "values(@nome, @cpf, @bairro, " +
                              "@cidade, @estado, @telefone, @email, @rua, @datanascimento, @profissao, @EstadoCivil, @sexo, @numero, @tipoRua, @complemento, @situacao)";
            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@datanascimento", datanascimento);
            cmd.Parameters.AddWithValue("@profissao", profissao);
            cmd.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipoRua", tipoRua);
            cmd.Parameters.AddWithValue("@complemento", complemento);
            cmd.Parameters.AddWithValue("@Situacao", situacao);
            

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
