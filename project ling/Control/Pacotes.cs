using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ling.Control
{
    public class Pacotes
    {
        private int cod_pacote;
        private string nome_pacote;
        private string valor_pacote;

        public int Cod_pacote { get => cod_pacote; set => cod_pacote = value; }
        public string Nome_pacote { get => nome_pacote; set => nome_pacote = value; }
        public string Valor_pacote { get => valor_pacote; set => valor_pacote = value; }
    }
}
