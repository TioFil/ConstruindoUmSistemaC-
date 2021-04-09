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
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

           Usuario usuario  = new Usuario();

            usuario.User = txt_User.Text;
            usuario.Senha = Convert.ToInt16(txt_Senha.Text);
            usuario.Codigo_Setor = Convert.ToInt32(txt_Codigo_Setor.Text);
            usuario.Email_interno = txt_Email_interno.Text;
            usuario.Cargo = txt_Cargo.Text;
            //Chama o método para inserir um cliente no banco de dados.
            usuario.InserirUsuario(usuario);
            MessageBox.Show("Registro inserido com sucesso.");


        }

        private void CadastroUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
