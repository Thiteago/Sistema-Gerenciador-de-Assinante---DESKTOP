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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void TrazDado(string Nome)
        {

        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            Form_Usuarios open = new Form_Usuarios();
            open.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adicionarNovoAssinanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadAssinante open = new Form_CadAssinante();

            open.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuarios open = new Form_Usuarios();
            open.Show();
        }

        private void gerenciarAssinantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Assinante ass = new Form_Assinante();
            ass.Show();
            this.Hide();
        }

        private void ordensEmPendenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Relatorio opn = new Form_Relatorio();

            opn.Show();
        }

        private void ordensPorPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RelatorioPeriodo form = new Form_RelatorioPeriodo();

            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UsuarioPendente abre = new Form_UsuarioPendente();

            abre.Show();
            this.Hide();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void todosOsUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Usuarios open = new Form_Usuarios();
            open.Show();
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroUsuario cad = new Form_CadastroUsuario();

            cad.Show();
        }
    }
}
