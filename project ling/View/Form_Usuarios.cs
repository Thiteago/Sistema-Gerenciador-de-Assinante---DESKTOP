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
    public partial class Form_Usuarios : Form
    {


        public Form_Usuarios()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            UsuarioDAO usuario = new UsuarioDAO();
            usuarios = usuario.MostrarUsuarios().ToList();

            
           foreach(var item in usuarios)
            {
                ListViewItem lv1 = new ListViewItem(item.Nome);
                lv1.SubItems.Add(item.Cargo);
                lv1.SubItems.Add(item.ID1.ToString());

                listViewUsuarios.Items.Add(lv1);
                    
            }

          
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            List<string> usuario = new List<string>();
            Form_AlterarUsuario altUser = new Form_AlterarUsuario();


            if(listViewUsuarios.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Não há nenhum usuário selecionado");
            }
            else
            {
                usuario.Add(listViewUsuarios.SelectedItems[0].SubItems[0].Text);
                usuario.Add(listViewUsuarios.SelectedItems[0].SubItems[1].Text);
                usuario.Add(listViewUsuarios.SelectedItems[0].SubItems[2].Text);
                altUser.CarregarDados(usuario[0], usuario[1], int.Parse(usuario[2]));
                this.Hide();
                altUser.ShowDialog();
                
            }
            


            
            

          
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string pessoa = listViewUsuarios.SelectedItems[0].SubItems[2].Text;

            Console.WriteLine(pessoa);
        }
    }
}
