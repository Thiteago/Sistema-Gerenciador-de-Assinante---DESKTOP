using project_ling.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        public void MostrarDados(DateTime DataNascimento,string cpf, string profissao, string estadoCivil, string sexo, string email, string rua, string tipoRua, string numeroRua, string bairro, string complemento,string nome, string cidade, string estado, string telefone,int id)
        {
            boxID.Text = id.ToString();
            nomeCompleto.Text = nome;
            cpfBox.Text = cpf;
            ruaBox.Text = rua;
            numeroBox.Text = numeroRua;
            boxTipo.Text = tipoRua;
            BoxBairro.Text = bairro;
            BoxCidade.Text = cidade;
            BoxEstado.Text = estado;
            BoxTelefone.Text = telefone;
            boxSexo.Text = sexo;
            boxComplemento.Text = complemento;
            BoxEmail.Text = email;
            Boxdtanasc.Value = DataNascimento;
            txtProfissao.Text = profissao;
            boxEstadoCivil.Text = estadoCivil;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            nomeCompleto.Text = "";
            cpfBox.Text = "";
            ruaBox.Text = "";
            BoxBairro.Text = "";
            BoxCidade.Text = "";
            BoxEstado.Text = "";
            BoxTelefone.Text = "";
            BoxEmail.Text = "";
            txtProfissao.Text = "";
            boxEstadoCivil.Text = "";
            boxSexo.Text = "";
            boxTipo.Text = "";
            numeroBox.Text = "";
            boxComplemento.Text = "";
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            AssinanteDAO assinante = new AssinanteDAO();
            assinante.AlterarDados(nomeCompleto.Text, Boxdtanasc.Value, cpfBox.Text, txtProfissao.Text, boxEstadoCivil.Text, boxSexo.Text, BoxEmail.Text, ruaBox.Text, boxTipo.Text, numeroBox.Text, BoxBairro.Text, boxComplemento.Text, BoxCidade.Text, BoxEstado.Text, BoxTelefone.Text,boxID.Text);
            
            this.Close();
        }
    }
}
