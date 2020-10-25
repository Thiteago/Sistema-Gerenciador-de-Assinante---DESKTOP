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
    public partial class Form_Relatorio : Form
    {
        public Form_Relatorio()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Relatorio_Load(object sender, EventArgs e)
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();
            OrdemDAO ordem = new OrdemDAO();

            ordens = ordem.MostrarPendentes().ToList();

            
            foreach(var item in ordens)
            {
                if (item.Situacao == "Pendente") {
                    ListViewItem lv1 = new ListViewItem(item.IdCliente.ToString());
                    lv1.SubItems.Add(item.Nome);
                    lv1.SubItems.Add(item.NumeroOS.ToString());
                    lv1.SubItems.Add(item.Situacao);

                    listViewPendentes.Items.Add(lv1);
                }
            }
        }

        private void listViewPendentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
