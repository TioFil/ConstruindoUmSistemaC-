using CrudCSharp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCSharp
{
    public partial class Login : Form
    {

        public Usuario UsuarioLogado { get; set; }

        public Login()
        {
            InitializeComponent();
           // buttonCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            txt_Senha.Text = Convert.ToString(usuario.Senha);
            txt_User.Text = Convert.ToString(usuario.User);

            

        }




        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_LogoutUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txt_User.Text))
                {
                    if (!String.IsNullOrEmpty(txt_Senha.Text))
                    {
                        UsuarioLogado = Usuario.Logar(txt_User.Text, Convert.ToInt32(txt_Senha.Text));

                        if (UsuarioLogado != null)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else
                        {
                            txt_User.Text = txt_User.Text = "";
                            MessageBox.Show("Nome de Usuário Incorreto !!!");
                        }
                        
                      
                        {

                        }
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }
            
            
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

