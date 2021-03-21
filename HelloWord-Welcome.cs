using CrudCSharp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCSharp
{
    public partial class HelloWord_Welcome : Form
    {

        public HelloWord_Welcome(Usuario _usuarioLogado)
        {
            InitializeComponent();
            LabelUsuario.Text = _usuarioLogado.User;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Usuarios usuarios = new Usuarios();
            usuarios.Owner = this;
            usuarios.Show();

            /*

            CadastroUsuarios cadastroUsuarios = new CadastroUsuarios();
            cadastroUsuarios.Owner = this;
            cadastroUsuarios.Show();
            */
        }

        private void HelloWord_Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
