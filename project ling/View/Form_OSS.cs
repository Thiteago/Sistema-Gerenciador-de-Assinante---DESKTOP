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
    public partial class Form_OSS : Form
    {
        public Form_OSS()
        {
            InitializeComponent();
        }
        OrdemDAO os = new OrdemDAO();
        List<OrdemdeServico> ordens = new List<OrdemdeServico>();
        

        public int pega()
        {
            int p = int.Parse(boxCod_Cliente.Text);

            return p;
        }


        public void CarregaDados(List<Assinante> lista)
        {

            foreach (Assinante i in lista)
            {
                boxCod_Cliente.Text = i.Id.ToString();
                boxNome.Text = i.Nome;
                boxTipoRua.Text = i.TipoRua;
                boxRua.Text = i.Rua;
                boxNumero.Text = i.NumeroRua.ToString();
                boxComplemento.Text = i.Complemento;
            }

        }

        public void MostrarDados(int cod, string nome, string tiporua, string end, string num, string compl)
        {
            boxCod_Cliente.Text = cod.ToString();
            boxNome.Text = nome;
            boxTipoRua.Text = tiporua;
            boxRua.Text = end;
            boxNumero.Text = num;
            boxComplemento.Text = compl;
        }

        public void LimparDGV()
        {
            dgv1.DataSource = "";
        }

        public void CarregarDGV(int id)
        {
            ordens = os.MostrarOS(id).ToList();
            dgv1.DataSource = ordens;
            dgv1.Columns["idCliente"].Visible = false;
            dgv1.Columns["Servico"].Visible = false;
            dgv1.Columns["Observacao"].Visible = false;  
        }


        private void Form_OSS_Load(object sender, EventArgs e)
        {
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionarOS_Click(object sender, EventArgs e)
        {
            Form_AdicionarOS add = new Form_AdicionarOS();
            add.MostrarDados(boxCod_Cliente.Text, boxNome.Text);
            add.Show();
            this.Hide();
        }

        private void Form_OSS_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form_OSS_Activated(object sender, EventArgs e)
        {
            dgv1.Refresh();
            Console.WriteLine(boxCod_Cliente.Text);


        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];

            boxServico.Text = ordem.Servico;
            boxObservacoes.Text = ordem.Observacao;

        }

        private void btAlterarOS_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];
            Form_AltOS os = new Form_AltOS();


            os.Show();
            os.MostrarDados(ordem.IdCliente, boxNome.Text, ordem.Servico, ordem.Observacao, ordem.DataAbertura, ordem.NumeroOS);
            this.Hide();
            
        }

        private void btDeletarOS_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];
            OrdemDAO del = new OrdemDAO();

            DialogResult resposta = MessageBox.Show("Voce realmente deseja deletar esta O.S?", "Confirme", MessageBoxButtons.YesNoCancel);
            if (resposta == DialogResult.Yes)
            {
                del.DeletarOS(ordem.NumeroOS);
            }

            LimparDGV();
            CarregarDGV(int.Parse(boxCod_Cliente.Text));
        }

        private void picBaixar_Click(object sender, EventArgs e)
        {
            OrdemdeServico ordem = ordens[dgv1.CurrentCell.RowIndex];
            OrdemDAO baix = new OrdemDAO();

            baix.BaixarOS(ordem.NumeroOS);
            LimparDGV();
            CarregarDGV(int.Parse(boxCod_Cliente.Text));
        }
    }
}
