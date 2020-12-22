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

        public List<Usuario> Users { get; set; } = new List<Usuario>();
        UsuarioDAO pap = new UsuarioDAO();
        

        public Form_UsuarioPendente()
        {
            InitializeComponent();
        }

        private void Form_UsuarioPendente_Load(object sender, EventArgs e)
        {
            Users = pap.MostrarUsuarioPendente().ToList();
            DGVUsuarios.DataSource = Users;
            DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
            DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Form_Principal fp = new Form_Principal();

            Close();
            fp.Show();
        }

        private void btAprovar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            string id = "";
            Usuario user = Users[DGVUsuarios.CurrentCell.RowIndex];

            cad.Cadastrar(user.Nome, user.Nascimento, user.Email, user.Telefone, user.Rua, user.Cidade, user.Estado, user.UsuarioAcesso, user.SenhaAcesso, user.Cargo, user.Sexo1, comboNivel.Text);
            MessageBox.Show(cad.mensagem);

            Users = pap.MostrarUsuarioPendente().ToList();
            DGVUsuarios.DataSource = "";
            DGVUsuarios.DataSource = Users;
            DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
            DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;

        }

        private void btRecusar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            Usuario user = Users[DGVUsuarios.CurrentCell.RowIndex];

            cad.RecusarCadastro(user.Email);
            MessageBox.Show(cad.mensagem);

            Users = pap.MostrarUsuarioPendente().ToList();
            DGVUsuarios.DataSource = "";
            DGVUsuarios.DataSource = Users;
            DGVUsuarios.Columns["SenhaAcesso"].Visible = false;
            DGVUsuarios.Columns["NivelDeAcesso1"].Visible = false;

        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario user = new Usuario();

            user = Users[DGVUsuarios.CurrentCell.RowIndex];

            txtID.Text = user.ID1.ToString();
            txtNome.Text = user.Nome;



        }
    }
}
