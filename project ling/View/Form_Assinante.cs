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
    public partial class Form_Assinante : Form
    {
        public Form_Assinante()
        {
            InitializeComponent();
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
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Assinante assinante = new Assinante();
            AssinanteDAO buscar = new AssinanteDAO();
            assinante = buscar.pesquisa(categoria.Text, boxBusca.Text);

            boxNascimento.Text = assinante.Datanascimento;
            boxCPF.Text = assinante.Cpf;
            boxProfissao.Text = assinante.Profissao;
            boxEstadoCivil.Text = assinante.Estado;
            boxSexo.Text = assinante.Sexo;
            boxEmail.Text = assinante.Email;
            nomeEndereco.Text = assinante.Rua;
            tipoRua.Text = assinante.TipoRua;
            numeroEndereco.Text = assinante.NumeroRua.ToString();
            bairroEndereco.Text = assinante.Bairro;
            boxComplemento.Text = assinante.Complemento;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
