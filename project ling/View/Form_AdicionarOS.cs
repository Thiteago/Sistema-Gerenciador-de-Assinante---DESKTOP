using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using project_ling.Model;

namespace project_ling.View
{
    
    public partial class Form_AdicionarOS : Form
    {
        public Form_AdicionarOS()
        {
            InitializeComponent();
        }

        public void MostrarDados(string id, string nome)
        {
            boxCod_Cliente.Text = id.ToString();
            boxNome.Text = nome;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_AdicionarOS_Load(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            boxData.Text = hora.ToString("d");
        }

        private void boxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            OrdemDAO gravar = new OrdemDAO();
            int cod = int.Parse(boxCod_Cliente.Text);
            DateTime data = DateTime.Parse(boxData.Text);
            gravar.AdicionarOS(cod, comboServico.Text, boxObservacao.Text, data);
            Close();
        }
    }
}
