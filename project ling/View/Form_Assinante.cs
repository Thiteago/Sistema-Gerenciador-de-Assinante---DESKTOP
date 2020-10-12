using project_ling.Control;
using project_ling.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ling.View
{
    public partial class Form_Assinante : Form
    {
        public List<Assinante> Assinantes { get; set; } = new List<Assinante>();
        public Form_Assinante()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[0].Name = "Id";
            //dataGridView1.Columns[1].Name = "Nome";



        }

        private void boxNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_CadAssinante fca = new Form_CadAssinante();
            fca.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Console.WriteLine();
            Form_Principal fp = new Form_Principal();
            fp.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Assinante assinante = new Assinante();
            AssinanteDAO buscar = new AssinanteDAO();
            Assinantes = buscar.pesquisa(categoria.Text, boxBusca.Text).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = Assinantes;
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["Bairro"].Visible = false;
            dataGridView1.Columns["Cidade"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.Columns["Telefone"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Rua"].Visible = false;
            dataGridView1.Columns["datanascimento"].Visible = false;
            dataGridView1.Columns["Profissao"].Visible = false;
            dataGridView1.Columns["EstadoCivil"].Visible = false;
            dataGridView1.Columns["Sexo"].Visible = false;
            dataGridView1.Columns["TipoRua"].Visible = false;
            dataGridView1.Columns["NumeroRua"].Visible = false;
            dataGridView1.Columns["Complemento"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Assinante assinante = Assinantes[dataGridView1.CurrentCell.RowIndex];

            boxNascimento.Text = assinante.Datanascimento.ToString("d");
            boxCPF.Text = assinante.Cpf;
            boxProfissao.Text = assinante.Profissao;
            boxEstadoCivil.Text = assinante.EstadoCivil;
            boxSexo.Text = assinante.Sexo;
            boxEmail.Text = assinante.Email;
            nomeEndereco.Text = assinante.Rua;
            tipoRua.Text = assinante.TipoRua;
            numeroEndereco.Text = assinante.NumeroRua.ToString();
            bairroEndereco.Text = assinante.Bairro;
            boxComplemento.Text = assinante.Complemento;
            boxEstado.Text = assinante.Estado;
            boxCidade.Text = assinante.Cidade;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Assinante assinante = Assinantes[dataGridView1.CurrentCell.RowIndex];

            Form_AltAssinante Mostra = new Form_AltAssinante();
            Mostra.Show();
            Mostra.MostrarDados(assinante.Datanascimento, assinante.Cpf, assinante.Profissao, assinante.EstadoCivil, assinante.Sexo, assinante.Email, assinante.Rua, assinante.TipoRua, assinante.NumeroRua.ToString(), assinante.Bairro, assinante.Complemento, assinante.Nome, assinante.Cidade, assinante.Estado, assinante.Telefone,assinante.Id);
        }

        private void deleteBotao_Click(object sender, EventArgs e)
        {
            Assinante assinante = Assinantes[dataGridView1.CurrentCell.RowIndex];
            AssinanteDAO assinantedel = new AssinanteDAO();
            DialogResult resposta = MessageBox.Show("Voce realmente deseja deletar o assinante?", "Confirme", MessageBoxButtons.YesNoCancel);
            if(resposta == DialogResult.Yes)
            {
                assinantedel.DeletarAssinante(assinante.Id.ToString());
            }

            

            dataGridView1.Refresh();
        }

        private void boxCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
