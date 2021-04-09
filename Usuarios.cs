using iTextSharp.text;
using iTextSharp.text.pdf;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCSharp
{
    public partial class Usuarios : Form
    {
        public bool IsPostBack { get; private set; }

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
            }


            //O codigo abaixo foi esta sendo utilizado para puxar as informações do banco de dados e preencher 
            //a Data Grid
            // A Procedure carregar usuários preenche a datagrid com as informações do banco.
            DataTable dt = new DataTable();
            SqlConnection myConn = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("CarregarUsuarios", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dt);
            DtGridUsuarios.DataSource = dt;
        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void DtGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RelatorioPdf relatorioPdf = new RelatorioPdf();
            relatorioPdf.Owner = this;
            relatorioPdf.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerarPdfDeUmUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioPdf relatorio = new RelatorioPdf();
            relatorio.Owner = this;
            relatorio.Show();

        }

        private void novoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroUsuarios cadastro = new CadastroUsuarios();
            cadastro.Owner = this;
            cadastro.Show();
        }
    }




}

    

