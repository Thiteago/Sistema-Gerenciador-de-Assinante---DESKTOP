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
    public partial class Form_Agendamento : Form
    {
        public Form_Agendamento()
        {
            InitializeComponent();
        }

        List<OrdemdeServico> ordens = new List<OrdemdeServico>();
        OrdemDAO os = new OrdemDAO();

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Principal fpc = new Form_Principal();
            fpc.Show();
        }

        public void LimparDGV()
        {
            dgv1.DataSource = "";
        }

        public void CarregarDGV(DateTime data)
        {
            data = calend.Value;
            ordens = os.MostarOrdemAgendada(data.ToString("dd/MM/yyyy")).ToList();

            dgv1.DataSource = ordens;
        }

        private void Form_Agendamento_Load(object sender, EventArgs e)
        {
            CarregarDGV(calend.Value);


        }


        private void calend_ValueChanged(object sender, EventArgs e)
        {
            LimparDGV();
            DateTime data = calend.Value;
            CarregarDGV(data);
            
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_Click(object sender, EventArgs e)
        {



        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];

            txtOS.Text = ordem.NumeroOS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];

            dgv1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
            os.InsereCor(ordem.NumeroOS, "Vermelho");
        }

        private void btExecutado_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];

            dgv1.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
            os.InsereCor(ordem.NumeroOS, "Verde");
        }

        private void btAtendimento_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];

            dgv1.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
            os.InsereCor(ordem.NumeroOS, "Amarelo");
        }

        private void Form_Agendamento_Enter(object sender, EventArgs e)
        {

        }
    }
}
