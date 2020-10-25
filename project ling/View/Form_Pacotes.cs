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
    public partial class Form_Pacotes : Form
    {
        public Form_Pacotes()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void MostrarDados(int ID)
        {
            boxID.Text = ID.ToString();
        }
        private void Form_Pacotes_Load(object sender, EventArgs e)
        {
            List<Pacotes> pacotes = new List<Pacotes>();
            List<Pacotes> dd = new List<Pacotes>();
            AssinanteDAO assinante = new AssinanteDAO();
            PacoteDAO pac = new PacoteDAO();

            pacotes = assinante.ListarPacotes().ToList();

            foreach(var item in pacotes)
            {
                checkedListBox1.Items.Add(item.Nome_pacote);
            }
            foreach(var item in pacotes)
            {
                checkedListBox1.Items.Add(item.Nome_pacote);
            }

            string ID = boxID.Text;
            dd = pac.MostrarPacotes(Convert.ToInt32(ID)).ToList();

            foreach(var item in dd)
            {
                ListViewItem lv1 = new ListViewItem(item.Nome_pacote);
                listView1.Items.Add(lv1);
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
                {
                    checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                    checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                    checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
                }
        }

    

        private void btAdicionarPAC_Click(object sender, EventArgs e)
        {
            
        }

        private void btAdicionarPAC_Click_1(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
            btAdicionar.Visible = true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            List<string> selec = new List<string>();
            PacoteDAO pac = new PacoteDAO();
            string ID = boxID.Text;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selec.Add(item.ToString());
                
            }
            pac.AdicionarPacote(Convert.ToInt32(ID), selec);
        }

        private void btRemoverPacote_Click(object sender, EventArgs e)
        {
            PacoteDAO pac = new PacoteDAO();
            pac.DeletarPacote(int.Parse(boxID.Text));
        }
    }
}
