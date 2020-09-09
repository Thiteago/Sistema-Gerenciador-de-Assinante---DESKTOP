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
    public partial class Assinante : Form
    {
        public string resultado;
        public Assinante()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Form_Principal fmp = new Form_Principal();
            fmp.Show();
            this.Close();
        }

        private void Assinante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDLP2DataSet1.Assinante'. Você pode movê-la ou removê-la conforme necessário.
            this.assinanteTableAdapter.Fill(this.bDLP2DataSet1.Assinante);
            // TODO: esta linha de código carrega dados na tabela 'bDLP2DataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.bDLP2DataSet.Usuario);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pesquisa.Text == "")
            {
                MessageBox.Show("É necessario preencher o campo busca");
            }else if(catPesquisa.Text == "Nome")
            {
                AssinanteDAO busca = new AssinanteDAO();
                resultado = busca.pesquisa(catPesquisa.Text, pesquisa.Text);
                MessageBox.Show(resultado);
            }
        }

        private void btCadAssinante_Click(object sender, EventArgs e)
        {
            Form_CadAssinante fca = new Form_CadAssinante();
            fca.Show();
        }

        private void catPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
