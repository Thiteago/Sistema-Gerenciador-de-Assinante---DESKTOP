using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ling.Model
{
    public class OrdemdeServico
    {
        private int numeroOS;
        private DateTime dataAbertura;
        private DateTime dataExecucao;
        private int idCliente;
        private string servico;
        private string observacao;
        private string valor;
        private string situacao;
        private string nome;


        public int NumeroOS { get => numeroOS; set => numeroOS = value; }
        public DateTime DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public DateTime DataExecucao { get => dataExecucao; set => dataExecucao = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Servico { get => servico; set => servico = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
