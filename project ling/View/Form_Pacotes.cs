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

        private void Form_Pacotes_Load(object sender, EventArgs e)
        {
            List<Pacotes> pacotes = new List<Pacotes>();
            AssinanteDAO assinante = new AssinanteDAO();

            pacotes = assinante.ListarPacotes().ToList();

            foreach(var item in pacotes)
            {
                checkedListBox1.Items.Add(item.Nome_pacote);
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
    }
}
