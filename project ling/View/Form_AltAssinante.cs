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
    public partial class Form_AltAssinante : Form
    {
        public Form_AltAssinante()
        {
            InitializeComponent();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            nomeCompleto.Text = "";
            cpf.Text = "";
            rua.Text = "";
            bairro.Text = "";
            cidade.Text = "";
            estado.Text = "";
            telefone.Text = "";
            email.Text = "";
            txtProfissao.Text = "";
            boxEstadoCivil.Text = "";
            boxSexo.Text = "";
            boxTipo.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
        }
    }
}
