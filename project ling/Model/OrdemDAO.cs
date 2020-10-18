using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace project_ling.Model
{
    class OrdemDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public String mensagem = "";
        OrdemdeServico ordem = new OrdemdeServico();
        OrdemdeServico aux = new OrdemdeServico();

        public void DeletarOS(int NumOS)
        {
            cmd.CommandText = @"DELETE FROM Ordem_de_Servico WHERE numeroOS = @os";
            cmd.Parameters.AddWithValue("@os", NumOS);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
        }



        public void AlterarOS(string numOS, string servico, string observacao, string valor)
        {
            cmd.CommandText = @"UPDATE Ordem_de_Servico
                              SET servico = @Servico,
                              Observacao = @obs,
                              Valor = @valor
                              WHERE numeroOS = @numOS";

            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@obs", observacao);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@numOS", numOS);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

        }

        public void AdicionarOS(int ID, string servico, string observacao, DateTime data_abertura, float valor)
        {
            cmd.CommandText = "INSERT INTO Ordem_de_Servico (data_abertura,ID_Cliente, servico, Observacao, Valor)" +
                              "VALUES(@DataAbertura, @ID, @Servico, @Observacao, @Valor)";

            cmd.Parameters.AddWithValue("@DataAbertura", data_abertura);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@Observacao", observacao);
            cmd.Parameters.AddWithValue("@Valor", valor);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
        }

        public IEnumerable<OrdemdeServico> MostrarOS(int id)
        {
            List<OrdemdeServico> ordem = new List<OrdemdeServico>();

            cmd.CommandText = "SELECT * FROM Ordem_de_Servico WHERE ID_Cliente = @Id";
            cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {


                    while (dr.Read())
                    {
                        aux = new OrdemdeServico();
                        aux.NumeroOS = int.Parse(dr["numeroOS"].ToString());
                        aux.DataAbertura = DateTime.Parse(dr["data_abertura"].ToString());
                        aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                        aux.Servico = dr["servico"].ToString();
                        aux.Observacao = dr["Observacao"].ToString();
                        aux.Valor = dr["Valor"].ToString();

                        ordem.Add(aux);


                    }
                    dr.Close();
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return ordem;

        }

    }
 }     

