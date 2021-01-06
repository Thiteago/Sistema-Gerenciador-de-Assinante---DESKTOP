using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_ling.Model;

namespace project_ling.View
{
    public partial class Form_UsuarioPendente : Form
    {
        //Criação de Lista genérica para armazenar os dados trazidos da classe UsuarioDAO
        public List<Usuario> Users { get; set; } = new List<Usuario>();
        UsuarioDAO pap = new UsuarioDAO();
        

        public Form_UsuarioPendente()
        {
            InitializeComponent();
        }

        private void Form_UsuarioPendente_Load(object sender, EventArgs e)
        {
            //Definindo a fonte de dados do DataGrid.
            Users = pap.MostrarUsuarioPendente().ToList();
            DGVUsuarios.DataSource = Users;
            DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
            DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;
            DGVUsuarios.Columns[0].HeaderText = "Nome";
            DGVUsuarios.Columns[1].HeaderText = "Nascimento";
            DGVUsuarios.Columns[2].HeaderText = "Email";
            DGVUsuarios.Columns[3].HeaderText = "Telefone";
            DGVUsuarios.Columns[4].HeaderText = "Rua";
            DGVUsuarios.Columns[5].HeaderText = "Cidade";
            DGVUsuarios.Columns[6].HeaderText = "Estado";
            DGVUsuarios.Columns[7].HeaderText = "Usuário";
            DGVUsuarios.Columns[8].HeaderText = "Cargo";
            DGVUsuarios.Columns[11].HeaderText = "ID";
            DGVUsuarios.Columns[12].HeaderText = "Sexo";
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            //Fecha o form
            Form_Principal fp = new Form_Principal();
            Close();
            fp.Show();
        }

        private void btAprovar_Click(object sender, EventArgs e)
        {
            
            Cadastro cad = new Cadastro();
            //Armazena os dados no objeto User passados pelo indice do datagrid

            if(comboNivel.Text == "")
            {
                MessageBox.Show("Não foi selecionado nenhum Nível de Acesso para o Usuário selecionado");
            }
            else if(DGVUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Não há usuário pendente selecionado à ser aprovado");
            }else
            {
                

                Usuario user = Users[DGVUsuarios.CurrentCell.RowIndex];

                //Faz o cadastro do Usuário selecionado
                cad.Cadastrar(user.Nome, user.Nascimento, user.Email, user.Telefone, user.Rua, user.Cidade, user.Estado, user.UsuarioAcesso, user.SenhaAcesso, user.Cargo, user.Sexo1, comboNivel.Text);
                MessageBox.Show(cad.mensagem);

                Users = pap.MostrarUsuarioPendente().ToList();
                DGVUsuarios.DataSource = "";
                DGVUsuarios.DataSource = Users;
                DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
                DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;
            }
            

        }

        private void btRecusar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            if (comboNivel.Text == "")
            {
                MessageBox.Show("Não foi selecionado nenhum Nível de Acesso para o Usuário selecionado");
            }
            else if (DGVUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("Não há usuário pendente selecionado à ser rejeitado");
            }
            else
            {

            
                Usuario user = Users[DGVUsuarios.CurrentCell.RowIndex];
                cad.RecusarCadastro(user.Email);
                MessageBox.Show(cad.mensagem);

                Users = pap.MostrarUsuarioPendente().ToList();
                DGVUsuarios.DataSource = "";
                DGVUsuarios.DataSource = Users;
                DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
                DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;
            }  

        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario user = new Usuario();

            user = Users[DGVUsuarios.CurrentCell.RowIndex];

            txtID.Text = user.ID1.ToString();
            txtNome.Text = user.Nome;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_CadastroUsuario cad = new Form_CadastroUsuario();

            cad.Show();
        }

        private void comboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
