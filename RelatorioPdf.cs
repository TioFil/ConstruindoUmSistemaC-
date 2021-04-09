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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CrudCSharp
{
    public partial class RelatorioPdf : Form
    {

        public RelatorioPdf()
        {
            InitializeComponent();
        }

        private void RelatorioPdf_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }


            string SqlDataPull = "Select U.User_Id as userId, U.iuser as iuser, U.senha  as Senha, U.codigo_setor as codigo_setor, U.email_Interno as email_Interno, U.cargo as Cargo  from Usuarios U  Where U.iuser = iuser";
            SqlCommand cmd = new SqlCommand(SqlDataPull);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SqlDataPull = dr[1].ToString();
                CbxCarregar.Items.Add(SqlDataPull);
            }
            dr.Close();
            
        }


        private DataTable GetData(string query)
        {
            string datapull = "Select U.User_Id as user_id, U.iuser as iuser, U.senha  as Senha, U.codigo_setor as codigo_setor, U.email_Interno as email_Interno, U.cargo as Cargo FROM  Usuarios U  Where U.iuser = iuser";
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            SqlCommand cmd = new SqlCommand(datapull);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["conString"]);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * From Usuarios";

            SqlDataReader reader = cmd.ExecuteReader();


            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("MeuRelatorio.pdf", FileMode.Create)); // asignamos el nombre de archivo hola.pdf
            doc.Open();
            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 28f, BaseColor.BLUE);
            title.Add("Relatorio De usuários");
            doc.Add(title);
            doc.Add(new Paragraph(" "));


            PdfPTable table = new PdfPTable(6);
            table.AddCell("Id_User");
            table.AddCell("iuser");
            table.AddCell("senha");
            table.AddCell("codigo_Setor");
            table.AddCell("email_Interno");
            table.AddCell("Cargo");


            while (reader.Read())
            {
                table.AddCell(reader.GetString(0).ToString());
                table.AddCell(reader.GetString(1).ToString());
                table.AddCell(reader.GetString(2).ToString());
                table.AddCell(reader.GetString(3).ToString());
                table.AddCell(reader.GetString(4).ToString());
                table.AddCell(reader.GetString(5).ToString());
            }
            doc.Add(table);
            doc.Close();
            conn.Close();

            */



            
            Document doc = new Document(PageSize.A4.Rotate());
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            string Caminho = AppDomain.CurrentDomain.BaseDirectory + @"\application" + "RelatorioCarlos.pdf";
            PdfWriter.GetInstance(doc, new FileStream(Caminho, FileMode.Create));
            doc.Open();

            Paragraph title = new Paragraph();
            title.Font = FontFactory.GetFont(FontFactory.TIMES, 28f, BaseColor.BLUE);
            title.Add("Relatorio De usuários");
            doc.Add(title);

            doc.Add(new Paragraph(" "));
            DataRow dr = GetData( "Select U.User_Id as user_id, U.iuser as iuser, U.senha as senha, U.codigo_setor as codigo_setor, U.email_Interno as email_Interno, U.cargo as cargo FROM  Usuarios U  Where U.iuser = iuser" + CbxCarregar.SelectedItem.ToString()).Rows[0];

            iTextSharp.text.Font fz = FontFactory.GetFont("Arial", 14, BaseColor.BLACK);
            Phrase phase = null;
            PdfPCell cell = null;
            PdfPTable table = null;
            table = new PdfPTable(2);
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            table.SetWidths(new float[] { 0.3f, 0.7f });
            phase = new Phrase();
            phase.Add(new Chunk("Tuscano Equipments Private Limited\n\n", FontFactory.GetFont("Arial", 16, BaseColor.RED)));
            phase.Add(new Chunk("Jammi Building,\n", FontFactory.GetFont("Arial", 14, BaseColor.BLUE)));
            phase.Add(new Chunk("Royapettah,Chennai", FontFactory.GetFont("Arial", 14, BaseColor.BLUE)));
            cell = PhraseCell(phase, PdfPCell.ALIGN_LEFT);
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            table.AddCell(cell);

            table = new PdfPTable(2);
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            table.SetWidths(new float[] { 0.3f, 1f });
            table.SpacingBefore = 20f;

            cell = new PdfPCell(new Phrase("Technician Record", FontFactory.GetFont("Arial", 12, BaseColor.BLACK)));
            cell.Colspan = 2;
            table.AddCell(cell);
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 30f;
            table.AddCell(cell);

            table = new PdfPTable(2);
            table.SetWidths(new float[] { 0.5f, 2f });
            table.TotalWidth = 340f;
            table.LockedWidth = true;
            table.SpacingBefore = 20f;
            table.HorizontalAlignment = Element.ALIGN_RIGHT;

            table.AddCell(PhraseCell(new Phrase("Id De Usuario:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            table.AddCell(PhraseCell(new Phrase("000"+ dr["User_Id"], FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);

            table.AddCell(PhraseCell(new Phrase("Nome De Usuário:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            phase = new Phrase(new Chunk(dr["iuser"] + "\n", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
            table.AddCell(PhraseCell(phase, PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);

            table.AddCell(PhraseCell(new Phrase("Senha De usuário:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            table.AddCell(PhraseCell(new Phrase(Convert.ToInt32(dr["senha"]).ToString(), FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);

            table.AddCell(PhraseCell(new Phrase("Codigo do Setor:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            table.AddCell(PhraseCell(new Phrase(dr["codigo_setor"] + "\n", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
          
            table.AddCell(PhraseCell(new Phrase("Email Interno:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            phase = new Phrase(new Chunk(dr["email_Interno"] + "\n", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
            table.AddCell(PhraseCell(phase, PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);

            table.AddCell(PhraseCell(new Phrase("Cargo Ocupacional:", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)), PdfPCell.ALIGN_LEFT));
            phase = new Phrase(new Chunk(dr["cargo"] + "\n", FontFactory.GetFont("Arial", 10, BaseColor.BLACK)));
            table.AddCell(PhraseCell(phase, PdfPCell.ALIGN_LEFT));
            cell = PhraseCell(new Phrase(), PdfPCell.ALIGN_CENTER);
            cell.Colspan = 2;
            cell.PaddingBottom = 10f;
            table.AddCell(cell);
           
            

            try
            {
                doc.Add(phase);
                doc.Add(table);
                doc.Add(cell);
                MessageBox.Show("Pfd Gerado com sucesso");

                RelatorioPdf  relatorio= new RelatorioPdf();
                relatorio.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("Não Foi possivel Gerar O pdf", ex);
            }

            finally
            {
                doc.Close();

            }
        }
        
        private static PdfPCell PhraseCell(Phrase phase, int align)
        {
            PdfPCell cell = new PdfPCell(phase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
           
        }
        
        
    }

    internal class Globais
    {
    }
}
