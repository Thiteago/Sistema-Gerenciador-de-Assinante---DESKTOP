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
    public partial class Form_SemAgendamento : Form
    {
        public Form_SemAgendamento()
        {
            InitializeComponent();
        }
        List<OrdemdeServico> ordem = new List<OrdemdeServico>();
        OrdemDAO os = new OrdemDAO();

        private void Form_SemAgendamento_Load(object sender, EventArgs e)
        {
        }

        public void LimparDGV()
        {
            dgv1.DataSource = "";
        }

        public void CarregarDGV()
        {
            ordem = os.MostrarOrdemNaoAgendada().ToList();

            dgv1.DataSource = ordem;
            dgv1.Columns["Observacao"].Visible = false;
            dgv1.Columns["DataExecucao"].Visible = false;
            dgv1.Columns["Situacao"].Visible = false;
            dgv1.Columns["DataAgendamento"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Principal fp = new Form_Principal();
            this.Close();

            fp.Show();

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdemdeServico ord = ordem[dgv1.CurrentCell.RowIndex];

            txtOS.Text = ord.NumeroOS.ToString();
        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            os.AgendarOS(dataSelec.Value, int.Parse(txtOS.Text));

            LimparDGV();
            CarregarDGV();
            
        }
    }
}
