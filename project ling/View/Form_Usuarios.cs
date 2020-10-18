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
                listViewUsuarios.Items.Add(new ListViewItem(new string[] { item.Nome}));
               
               
            }

          
        }

        private void listViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
