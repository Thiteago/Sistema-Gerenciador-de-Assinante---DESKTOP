using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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


        public IEnumerable<OrdemdeServico> MostrarPorPeriodo(string situacao, DateTime desde, DateTime Ate, List<string> TipoOrdem)
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();

                cmd.CommandText = "SELECT numeroOS, data_abertura, data_execucao, ID_Cliente, servico,situacao, Nome " +
                                  "FROM Ordem_de_Servico " +
                                  "INNER JOIN Assinante ON Ordem_de_Servico.ID_Cliente = Assinante.ID " +
                                  "WHERE Situacao = @sit AND  data_abertura >= @dtaAB AND data_abertura <= @dtaFEC";

                cmd.Parameters.AddWithValue("@sit", situacao);
                cmd.Parameters.AddWithValue("@dtaAB", desde.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@dtaFEC", Ate.ToString("dd/MM/yyyy"));
 


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
                        aux.Valor = float.Parse(dr["Valor"].ToString());
                        aux.Situacao = dr["Situacao"].ToString();
                        aux.Nome = dr["Nome"].ToString();
                        aux.Observacao = dr["Observacao"].ToString();
                        foreach (var item in TipoOrdem)
                        {
                            if (item == dr["servico"].ToString())
                            {
                                aux.Servico = dr["servico"].ToString();
                            }
                        }
                        ordens.Add(aux);

                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
            Console.WriteLine(aux.NumeroOS);
        return ordens;
    }

        

        public IEnumerable<OrdemdeServico> MostrarPendentes()
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();
            cmd.CommandText = "SELECT * FROM Ordem_de_Servico INNER JOIN Assinante ON Ordem_de_Servico.ID_Cliente = Assinante.ID";

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
                        aux.Valor = float.Parse(dr["Valor"].ToString());
                        aux.Situacao = dr["Situacao"].ToString();
                        aux.Nome = dr["Nome"].ToString();
                        

                        ordens.Add(aux);


                    }
                    dr.Close();
                }
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return ordens;
        }




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
            string pendente = "Pendente";
            cmd.CommandText = "INSERT INTO Ordem_de_Servico (data_abertura,ID_Cliente, servico, Observacao, Valor, Situacao)" +
                              "VALUES(@DataAbertura, @ID, @Servico, @Observacao, @Valor, @situation)";

            cmd.Parameters.AddWithValue("@DataAbertura", data_abertura);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@Observacao", observacao);
            cmd.Parameters.AddWithValue("@Valor", valor);
            cmd.Parameters.AddWithValue("@situation", pendente);

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
                        aux.Valor = float.Parse(dr["Valor"].ToString());
                        aux.Situacao = dr["Situacao"].ToString();

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

