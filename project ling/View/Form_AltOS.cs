using project_ling.Control;
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
            Form_OSS os = new Form_OSS();
            AssinanteDAO pp = new AssinanteDAO();
            List<Assinante> criente = new List<Assinante>();
            int cod = int.Parse(boxCod_Cliente.Text);

            alt.AlterarOS(boxNumOS.Text, comboServico.Text, boxObservacao.Text);
            os.LimparDGV();
            os.CarregarDGV(cod);
            criente = pp.MostrarDadosAssinante(cod).ToList();
            os.CarregaDados(criente);

            this.Close();
            os.Show();
        }

        private void Form_AltOS_Load(object sender, EventArgs e)
        {

        }
    }
}
