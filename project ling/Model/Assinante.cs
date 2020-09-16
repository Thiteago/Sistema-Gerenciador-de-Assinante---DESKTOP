using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ling.Control
{
    public class Assinante
    {
        private int id;
        private string nome;
        private string cpf;
        private string rua;
        private string bairro;
        private string cidade;
        private string estado;
        private string telefone;
        private string email;
        private string datanascimento;
        private string profissao;
        private string estadoCivil;
        private string sexo;
        private string tipoRua;
        private int numeroRua;
        private string complemento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Datanascimento { get => datanascimento; set => datanascimento = value; }
        public string Profissao { get => profissao; set => profissao = value; }
        public string EstadoCivil1 { get => estadoCivil; set => estadoCivil = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string TipoRua { get => tipoRua; set => tipoRua = value; }
        public int NumeroRua { get => numeroRua; set => numeroRua = value; }
        public string Complemento { get => complemento; set => complemento = value; }
    }
}
