using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using project_ling.Control;

namespace project_ling.Model
{
    class AssinanteDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public String mensagem = "";
        Assinante cliente = new Assinante();
        

        public IEnumerable<Assinante> pesquisa(string categoria, string busca)
        {
            List<Assinante> assinantes = new List<Assinante>();
            if (categoria == "Nome")
            {
                cmd.CommandText = @"SELECT * FROM Assinante As C WHERE C.Nome LIKE @Nome";
                cmd.Parameters.AddWithValue("@Nome", busca + "%");
            }
            else if(categoria == "CPF")
            {
                cmd.CommandText = @"SELECT * FROM Assinante As C WHERE C.CPF LIKE @Cpf";
                cmd.Parameters.AddWithValue("@Cpf", busca + "%");
            }
            else if(categoria == "Endereço")
            {
                cmd.CommandText = @"SELECT * FROM Assinante As C WHERE C.Rua LIKE @Rua";
                cmd.Parameters.AddWithValue("@Rua", busca + "%");
            }
            else if(categoria == "Telefone")
            {
                cmd.CommandText = @"SELECT * FROM Assinante As C WHERE C.Telefone LIKE @Tel";
                cmd.Parameters.AddWithValue("@Tel", busca + "%");
            }
            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();

                  if (dr.HasRows)
                    {
                     

                    while (dr.Read())
                        {
                            cliente = new Assinante();
                            cliente.Id = int.Parse(dr["ID"].ToString());
                            cliente.Nome = dr["Nome"].ToString();
                            cliente.Cpf = dr["CPF"].ToString();
                            cliente.Rua = dr["Rua"].ToString();
                            cliente.Bairro = dr["Bairro"].ToString();
                            cliente.Cidade = dr["Cidade"].ToString();
                            cliente.Estado = dr["Estado"].ToString();
                            cliente.Telefone = dr["Telefone"].ToString();
                            cliente.Email = dr["Email"].ToString();
                            cliente.Datanascimento = DateTime.Parse(dr["datanascimento"].ToString());
                            cliente.Profissao = dr["Profissao"].ToString();
                            cliente.EstadoCivil = dr["EstadoCivil"].ToString();
                            cliente.Sexo = dr["Sexo"].ToString();
                            cliente.NumeroRua = int.Parse(dr["NumeroRua"].ToString());
                            cliente.TipoRua = dr["TipoRua"].ToString();
                            cliente.Complemento = dr["Complemento"].ToString();
                            assinantes.Add(cliente);
                            

                    }
                        dr.Close();
                }
                
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }
            return assinantes ;
        }
    }
}
