using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ling
{
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {   
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bot_Cadastrar(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("O Campo nome deve ser preenchdio!");
            }else if (txtEmail.Text == ""){
                MessageBox.Show("O Campo Email deve ser preenchido!");
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("O Campo Telefone deve ser preenchido!");
            }
            else if (txtRua.Text == "")
            {
                MessageBox.Show("O Campo Rua deve ser preenchido!");
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("O Campo Cidade deve ser preenchido!");
            }
            else if (listaEstado.Text == "")
            {
                MessageBox.Show("O Campo Estado deve ser preenchido!");
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("O Campo Usuario deve ser preenchido!");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("O Campo Senha deve ser preenchido!");
            }
            else
            {
                string datanasc = dtaEscolha.Value.ToString();
                Cadastro cad = new Cadastro(txtNome.Text, datanasc, txtEmail.Text, txtTel.Text,
                                            txtRua.Text, txtCidade.Text, listaEstado.Text, txtUsuario.Text,
                                            txtSenha.Text);
                MessageBox.Show(cad.msg);
                this.Close();
            }


            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
