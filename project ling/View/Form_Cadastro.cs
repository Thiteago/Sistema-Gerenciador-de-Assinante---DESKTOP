﻿using System;
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

            bool pode = false;
            Cadastro cap = new Cadastro();

            int veri = cap.CheckCadastro(txtEmail.Text, txtUsuario.Text);

            if (veri == 1)
            {
                MessageBox.Show("O Email Informado já foi cadastrado");
            }else if(veri == 3)
            {
                MessageBox.Show("O Usuario e Email informado ja foi cadastrado");
            }else if(veri == 0)
            {
                pode = true;
            }else if(veri == 2)
            {
                MessageBox.Show("O Usuario informado ja foi cadastrado");
            }

            if (txtNome.Text == "")
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



            if ((radioButton1.Checked == true) && (pode == true))
            {
                string datanasc = dtaEscolha.Value.ToString();
                cap.SolicitarCadastro(txtNome.Text, datanasc, txtEmail.Text, txtTel.Text,
                                            txtRua.Text, txtCidade.Text, listaEstado.Text, txtUsuario.Text,
                                            txtSenha.Text, boxCargo.Text, radioButton1.Text);
                MessageBox.Show(cap.mensagem);
                this.Close();

            }
            else if ((radioButton2.Checked == true) && (pode == true))
            {
                string datanasc = dtaEscolha.Value.ToString();
                cap.SolicitarCadastro(txtNome.Text, datanasc, txtEmail.Text, txtTel.Text,
                                            txtRua.Text, txtCidade.Text, listaEstado.Text, txtUsuario.Text,
                                            txtSenha.Text, boxCargo.Text, radioButton2.Text);
                MessageBox.Show(cap.mensagem);
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
