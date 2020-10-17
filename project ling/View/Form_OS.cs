﻿using project_ling.Model;
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
    public partial class Form_OS : Form
    {
        
        public List<OrdemdeServico> Ordem { get; set; } = new List<OrdemdeServico>();
        public Form_OS()
        {
            InitializeComponent();
        }

        public void MostrarDados(int id, string nome, string tipoRua, string rua, int numero, string complemento)
        {
            boxCod_Cliente.Text = id.ToString();
            boxNome.Text = nome;
            boxTipoRua.Text = tipoRua;
            boxRua.Text = rua;
            boxNumero.Text = numero.ToString();
            boxComplemento.Text = complemento;

        }


        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAdicionarOS_Click(object sender, EventArgs e)
        {
            Form_AdicionarOS open = new Form_AdicionarOS();
            open.MostrarDados(boxCod_Cliente.Text, boxNome.Text);



            open.Show();
        }

        private void Form_OS_Load(object sender, EventArgs e)
        {
            OrdemDAO source = new OrdemDAO();
            int id = int.Parse(boxCod_Cliente.Text);

            dataGridView2.DataSource = source.MostrarOS(id);
            dataGridView2.Columns["IdCliente"].Visible = false;
            dataGridView2.Columns["Servico"].Visible = false;
            dataGridView2.Columns["Observacao"].Visible = false;




        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdemdeServico ordem = Ordem[dataGridView2.CurrentCell.RowIndex];

            boxServico.Text = ordem.Servico;
            boxValor.Text = ordem.Valor.ToString();
            boxObservacoes.Text = ordem.Observacao;

        }
    }
}
