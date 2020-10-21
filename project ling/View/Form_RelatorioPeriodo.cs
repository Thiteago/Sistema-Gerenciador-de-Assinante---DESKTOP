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
    public partial class Form_RelatorioPeriodo : Form
    {
        public Form_RelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {

            listViewRelatorio.Items.Clear();

            OrdemDAO ordem = new OrdemDAO();
            List<string> Selecao = new List<string>();
            List<OrdemdeServico> OS = new List<OrdemdeServico>();

            foreach(var item in checkedListBox1.CheckedItems)
            {
                Selecao.Add(item.ToString());
            }
            


            OS = ordem.MostrarPorPeriodo(comboSituacao.Text, dpDe.Value.Date, dpAte.Value.Date, Selecao).ToList();


            foreach(var item in OS)
            {
                DateTime Tempo = new DateTime(0001, 1, 1);
                ListViewItem lv1 = new ListViewItem(item.IdCliente.ToString());
                lv1.SubItems.Add(item.NumeroOS.ToString());
                lv1.SubItems.Add(item.Servico);
                lv1.SubItems.Add(item.Nome);
                lv1.SubItems.Add(item.Situacao);
                lv1.SubItems.Add(item.DataAbertura.ToString("dd/MM/yyyy"));
                if(item.DataExecucao == Tempo)
                {
                    lv1.SubItems.Add(" ");
                }
                lv1.SubItems.Add(item.DataExecucao.ToString());
                listViewRelatorio.Items.Add(lv1);
            }
        }

        private void dpDe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_RelatorioPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
