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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace project_ling.View
{
    public partial class Form_Relatorio : Form
    {
        public Form_Relatorio()
        {
            InitializeComponent();
        }


        public void GerarPDF()
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Relatorio_Load(object sender, EventArgs e)
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();
            OrdemDAO ordem = new OrdemDAO();

            ordens = ordem.MostrarPendentes().ToList();

            
            foreach(var item in ordens)
            {
                if (item.Situacao == "Pendente") {
                    ListViewItem lv1 = new ListViewItem(item.IdCliente.ToString());
                    lv1.SubItems.Add(item.NumeroOS.ToString());
                    lv1.SubItems.Add(item.Situacao);

                    listViewPendentes.Items.Add(lv1);
                }
            }
        }

        private void listViewPendentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btGerarPDF_Click(object sender, EventArgs e)
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();
            OrdemDAO ordem = new OrdemDAO();
            ordens = ordem.MostrarPendentes().ToList();

            string pdfRelatorio = "C:\\Users\\ThIaG\\source\\repos\\LP2" + "\\pendentes.pdf";
            FileStream arquivoPDF = new FileStream(pdfRelatorio, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();
            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("RELATÓRIO DE ORDENS DE SERVIÇO COM PENDENCIA\n\n\n\n\n");

            
            PdfPTable tabela2 = new PdfPTable(1);
            PdfPTable tabela = new PdfPTable(4);
            

            tabela.AddCell("ID Cliente");
            tabela.AddCell("Nome");
            tabela.AddCell("Numero O.S");
            tabela.AddCell("Status");
            foreach (var item in ordens)
            {
                tabela.AddCell(item.IdCliente.ToString());
                tabela.AddCell(item.NumeroOS.ToString());
                tabela.AddCell(item.Situacao);
                
            }
            doc.Add(paragrafo);
            doc.Add(tabela);

            doc.Close();

            MessageBox.Show("PDF Gerado com Sucesso!");
            System.Diagnostics.Process.Start("C:\\Users\\ThIaG\\source\\repos\\LP2" + "\\pendentes.pdf");
        }
    }
}
