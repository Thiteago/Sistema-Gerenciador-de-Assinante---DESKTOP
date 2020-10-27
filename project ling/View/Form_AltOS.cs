using project_ling.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ling.View
{
    public partial class Form_AltOS : Form
    {
        public Form_AltOS()
        {
            InitializeComponent();
        }

        public void MostrarDados(int Id, string nome, string servico, string observacao, DateTime dataabertura, int numOS)
        {
            boxCod_Cliente.Text = Id.ToString();
            boxNome.Text = nome;
            comboServico.Text = servico;
            boxObservacao.Text = observacao;
            boxData.Text = dataabertura.ToString("d");
            boxNumOS.Text = numOS.ToString();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            OrdemDAO alt = new OrdemDAO();

            alt.AlterarOS(boxNumOS.Text, comboServico.Text, boxObservacao.Text);

            Close();
        }
    }
}
