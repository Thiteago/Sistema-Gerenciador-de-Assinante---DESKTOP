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
    public partial class Form_AlterarUsuario : Form
    {
        Form_Usuarios user = new Form_Usuarios();
        UsuarioDAO dao = new UsuarioDAO();
        List<Usuario> listUsuario = new List<Usuario>();

        public Form_AlterarUsuario()
        {
            InitializeComponent();
        }

        public void CarregarDados(string Nome, string Cargo, int ID)
        {

            
            listUsuario = dao.CarregarDados(Nome,Cargo,ID).ToList();

            txtNome.Text = listUsuario[0].Nome;
            dtaEscolha.Value = listUsuario[0].Nascimento;
            txtEmail.Text = listUsuario[0].Email;
            txtTel.Text = listUsuario[0].Telefone;
            txtRua.Text = listUsuario[0].Rua;
            txtCidade.Text = listUsuario[0].Cidade;
            listaEstado.Text = listUsuario[0].Estado;
            boxCargo.Text = listUsuario[0].Cargo;
            if(listUsuario[0].Sexo1 == "Masculino")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            txtUsuario.Text = listUsuario[0].UsuarioAcesso;

            txtSenha.Text = listUsuario[0].SenhaAcesso;
            comboNivel.Text = listUsuario[0].NivelDeAcesso1;
            txtID.Text = listUsuario[0].ID1.ToString();
            




        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            user.Show();
        }


        private void Form_AlterarUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void Form_AlterarUsuario_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool pode = false;
            Cadastro cap = new Cadastro();
            
            if(cap.CheckAlteracao(txtEmail.Text,txtUsuario.Text, int.Parse(txtID.Text)) == 3)
            {
                MessageBox.Show("O Novo Email Inserio ja existe!");
            }else if(cap.CheckAlteracao(txtEmail.Text, txtUsuario.Text, int.Parse(txtID.Text)) == 2)
            {
                MessageBox.Show("O Novo usuário inserido já existe");
            }else if(cap.CheckAlteracao(txtEmail.Text, txtUsuario.Text, int.Parse(txtID.Text)) == 1)
            {
                
                if (radioButton1.Checked == true)
                {
              
                    dao.AlterarUsuario(int.Parse(txtID.Text),txtNome.Text, dtaEscolha.Value, txtEmail.Text,txtTel.Text,txtRua.Text,txtCidade.Text,listaEstado.Text,boxCargo.Text,radioButton1.Text,txtUsuario.Text,txtSenha.Text,comboNivel.Text);
                    MessageBox.Show(cap.mensagem);
                  

                }
                else if (radioButton2.Checked == true)
                {
                    dao.AlterarUsuario(int.Parse(txtID.Text), txtNome.Text, dtaEscolha.Value, txtEmail.Text, txtTel.Text, txtRua.Text, txtCidade.Text, listaEstado.Text, boxCargo.Text, radioButton2.Text, txtUsuario.Text, txtSenha.Text, comboNivel.Text);
                    MessageBox.Show(cap.mensagem);
                    
                }
            }  
        }
    }
}
