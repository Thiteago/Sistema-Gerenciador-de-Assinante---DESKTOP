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

    public partial class Form_CadAssinante : Form
    {
        public Form_CadAssinante()
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
       
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string datanasc = dtanasc.Value.ToString();
            CadastroAssinante cad = new CadastroAssinante(nomeCompleto.Text, cpf.Text,rua.Text,bairro.Text,cidade.Text,estado.Text,
                                                          telefone.Text,email.Text,datanasc);
            MessageBox.Show(cad.msg);
            this.Close();
        }
    }
}
