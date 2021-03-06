﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_ling.Control;
using project_ling.Model;

namespace project_ling.View
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            UsuarioDAO check = new UsuarioDAO();
            Usuario user = new Usuario();

            if (email.Text == "")
            {
                MessageBox.Show("O Campo Usuario deve ser preenchido!");
            }
            else if (senha.Text == "")
            {
                MessageBox.Show("O Campo Senha deve ser preenchido!");
            }
            else
            {
                UsuarioController controle = new UsuarioController();
                controle.acessar(email.Text, senha.Text);
                if(check.CheckPendente(email.Text) == true)
                {
                    MessageBox.Show("Seu cadastro esta pendente da aprovação do administrador, aguarde e tente novamente mais tarde");
                }else if(controle.tem)
                {
                    user.Nome = email.Text;
                    Form_Principal fp = new Form_Principal();
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login nao encontrado!");
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cadastro abrirForm = new Form_Cadastro();
            abrirForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
