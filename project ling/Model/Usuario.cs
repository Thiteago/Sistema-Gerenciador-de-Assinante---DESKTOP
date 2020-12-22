using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace project_ling.Model
{
    public class Usuario
    {
        private string nome;
        private DateTime nascimento;
        private string email;
        private string telefone;
        private string rua;
        private string cidade;
        private string estado;
        private string usuarioAcesso;
        private string senhaAcesso;
        private string cargo;
        private string NivelDeAcesso;
        private int ID;
        private string Sexo;

        public string Nome { get => nome; set => nome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string UsuarioAcesso { get => usuarioAcesso; set => usuarioAcesso = value; }
        public string SenhaAcesso { get => senhaAcesso; set => senhaAcesso = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string NivelDeAcesso1 { get => NivelDeAcesso; set => NivelDeAcesso = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
    }
}
