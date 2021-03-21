using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharp.Classes
{
    public class Usuario
    {

        SqlConnection con = null;
        SqlCommand cmd = null;


        //adicionando a variavel con a função nativa sql conecction


        private string iuser;
        public string User


        {
            get { return iuser; }
            set { iuser = value; }
        }

        private int senha;
        public int Senha


        {
            get { return senha; }
            set { senha = value; }
        }

        private int codigo_setor;
        public int Codigo_Setor


        {
            get { return codigo_setor; }
            set { codigo_setor = value; }
        }

        private string email_interno;
        public string Email_interno


        {
            get { return email_interno; }
            set { email_interno = value; }
        }
        private string cargo;
        public string Cargo


        {
            get { return cargo; }
            set { cargo = value; }
        }


        public Usuario() { }

        public Usuario(string iuser, int senha, int codigo_setor, string email_interno, string cargo)
        {
            this.User = iuser;
            this.Senha = senha;
            this.Codigo_Setor = codigo_setor;
            this.Email_interno = email_interno;
            this.Cargo = cargo;

        }


        public static Usuario Logar(string iuser, int senha)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE iuser= @iuser and senha= @senha", con);
                cmd.Parameters.AddWithValue("@iuser", iuser);
                cmd.Parameters.AddWithValue("@senha", senha);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    Usuario obj = new Usuario();
                    obj.User = reader["iuser"].ToString();
                    obj.Senha = Convert.ToInt32(reader["senha"]);

                    return obj;

                }
                else
                {
                    return null;
                }


            }
            catch (Exception  ex)
            {

                throw new Exception("Não foi possivel realizar a operaçao!!!" + ex.Message);
            }
            finally
            {
                con.Close();
            }
           

            
        
        }
            public void InserirUsuario(Usuario usuario)
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            try
            {
                con.Open();
                cmd = new SqlCommand("InserirUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iuser", usuario.User);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@codigo_setor", usuario.Codigo_Setor);
                cmd.Parameters.AddWithValue("@email_interno", usuario.Email_interno);
                cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);

                //Executa o comando para realizar o cadastro no banco de dados
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Falha na operação: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}