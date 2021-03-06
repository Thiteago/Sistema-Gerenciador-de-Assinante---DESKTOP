﻿using System;
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
        public bool tem;
        OrdemdeServico ordem = new OrdemdeServico();
        OrdemdeServico aux = new OrdemdeServico();

        
        //Método para a verificação se Assinante possui Ordens com o status "Pendente"
        
        public string PegaCor(int NumOS)
        {
            string cor = "";

            cmd.CommandText = "SELECT Cor FROM Ordem_de_Servico WHERE numeroOS = @numOS";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@numOS", NumOS);

            try
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cor = dr["Cor"].ToString();
                    }
                }
            }catch(SqlException e)
            {

            }

            return cor;
        }



        public void InsereCor(int NumOS, string Cor)
        {
            cmd.CommandText = "UPDATE Ordem_de_Servico SET Cor = @cor WHERE numeroOS = @numOS";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cor", Cor);
            cmd.Parameters.AddWithValue("@numOS", NumOS);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            conexao.desconectar();
            dr.Close();

        }

        public bool CheckOS(string ID)
        {
            
            cmd.CommandText = "SELECT * FROM Ordem_de_Servico WHERE ID_Cliente = @id AND Situacao = 'Pendente'";
            cmd.Parameters.AddWithValue("@id", ID);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                tem = true;
            }
            dr.Close();
            return tem;
        }

        
        //Método que efetua a execução da ordem de serviço em pendente.

        public void BaixarOS(int numOS)
        {
            cmd.CommandText = "UPDATE Ordem_de_Servico "+
                              "SET Situacao = 'Executado', "+
                              "data_execucao = GETDATE() "+
                              "WHERE numeroOS = @numOS";
            cmd.Parameters.AddWithValue("@numOS", numOS);
            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();
            dr.Close();
            conexao.desconectar();
        }
        
        //Método para a geração do relatório por período , com dados por parâmetro para o auxilio na consulta

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

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string teste;
                    aux = new OrdemdeServico();
                    aux.NumeroOS = int.Parse(dr["numeroOS"].ToString());
                    aux.DataAbertura = DateTime.Parse(dr["data_abertura"].ToString());
                    aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                    aux.Situacao = dr["Situacao"].ToString();
                    teste = dr["servico"].ToString();
                    foreach (var item in TipoOrdem)
                    {
                        if (item == teste)
                        {
                            aux.Servico = dr["servico"].ToString();
                            ordens.Add(aux);
                        }

                    }

                }
                dr.Close();
            }
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
                        if (dr["situacao"].ToString() == "Pendente")
                        {
                            aux = new OrdemdeServico();
                            aux.NumeroOS = int.Parse(dr["numeroOS"].ToString());
                            aux.DataAbertura = DateTime.Parse(dr["data_abertura"].ToString());
                            aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                            aux.Servico = dr["servico"].ToString();
                            aux.Observacao = dr["Observacao"].ToString();
                            aux.Situacao = dr["Situacao"].ToString();
                            ordens.Add(aux);
                        }
                    }
                    dr.Close();
                }
            }
            catch (SqlException)
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



        public void AlterarOS(string numOS, string servico, string observacao)
        {
            cmd.CommandText = "UPDATE Ordem_de_Servico SET servico = @Servico, Observacao = @obs WHERE numeroOS = @numOS";

            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@obs", observacao);
            cmd.Parameters.AddWithValue("@numOS", numOS);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

        }

        public void AdicionarOS(int ID, string servico, string observacao, DateTime data_abertura)
        {
            string pendente = "Pendente";
            cmd.CommandText = "INSERT INTO Ordem_de_Servico (data_abertura,ID_Cliente, servico, Observacao, Situacao)" +
                              "VALUES(@DataAbertura, @ID, @Servico, @Observacao, @situation)";

            cmd.Parameters.AddWithValue("@DataAbertura", data_abertura);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Servico", servico);
            cmd.Parameters.AddWithValue("@Observacao", observacao);
            cmd.Parameters.AddWithValue("@situation", pendente);
            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

        }

        public void AgendarOS(DateTime Data, int numOS)
        {
            cmd.CommandText = "UPDATE Ordem_de_Servico SET Data_Agendamento = @data, Situacao = 'Agendado' WHERE numeroOS = @numOS";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@data", Data);
            cmd.Parameters.AddWithValue("@numOS", numOS);

            cmd.Connection = conexao.conectar();
            dr = cmd.ExecuteReader();

            conexao.desconectar();
            dr.Close();

        }

        public IEnumerable<OrdemdeServico> MostrarOrdemNaoAgendada()
        {
            List<OrdemdeServico> ordem = new List<OrdemdeServico>();

            cmd.CommandText = "SELECT * FROM Ordem_de_Servico WHERE Data_Agendamento IS NULL AND Situacao = 'Pendente'";

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
                        aux.Situacao = dr["Situacao"].ToString();
                        aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                        aux.Servico = dr["servico"].ToString();
                        aux.Observacao = dr["Observacao"].ToString();

                        ordem.Add(aux);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.desconectar();
            dr.Close();



            return ordem;
        }

        public IEnumerable<OrdemdeServico> MostarOrdemAgendada(string Data)
        {
            List<OrdemdeServico> ordem = new List<OrdemdeServico>();


            
            cmd.CommandText = "SELECT * FROM Ordem_de_Servico WHERE Data_Agendamento IS NOT NULL AND Situacao = 'Agendado' AND Data_Agendamento between @data1 and @data2";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@data1", Data + " 00:00:00");
            cmd.Parameters.AddWithValue("@data2", Data + " 23:59:59");

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
                        aux.Situacao = dr["Situacao"].ToString();
                        aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                        aux.Servico = dr["servico"].ToString();
                        aux.Observacao = dr["Observacao"].ToString();
                        DateTime.Now.ToString("dd/MM/yyyy"); 
                        DateTime dat = DateTime.Parse(dr["Data_Agendamento"].ToString());
                        Console.WriteLine(dat);
                        aux.DataAgendamento = dat;

                        ordem.Add(aux);
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            conexao.desconectar();
            dr.Close();


            return ordem;
        }
        public IEnumerable<OrdemdeServico> MostrarOS(int id)
        {
            List<OrdemdeServico> ordem = new List<OrdemdeServico>();

            cmd.CommandText = "SELECT * FROM Ordem_de_Servico WHERE ID_Cliente = @Id";
            cmd.Parameters.Clear();
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
                        aux.Situacao = dr["Situacao"].ToString();
                        if(aux.Situacao == "Agendado")
                        {
                            aux.DataAgendamento = DateTime.Parse(dr["Data_Agendamento"].ToString());
                        }
                        
                        if (aux.Situacao == "Executado")
                        {
                            aux.DataExecucao = DateTime.Parse(dr["data_execucao"].ToString());
                        }
                        aux.IdCliente = int.Parse(dr["ID_Cliente"].ToString());
                        aux.Servico = dr["servico"].ToString();
                        aux.Observacao = dr["Observacao"].ToString();
                        

                        ordem.Add(aux);


                    }
                    dr.Close();
                }
            }

            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

            return ordem;

        }

    }
 }     

