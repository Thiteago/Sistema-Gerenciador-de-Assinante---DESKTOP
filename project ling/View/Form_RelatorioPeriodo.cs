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
    public partial class Form_RelatorioPeriodo : Form
    {
        public Form_RelatorioPeriodo()
        {
            InitializeComponent();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {

            listViewRelatorio.Items.Clear();

            OrdemDAO ordem = new OrdemDAO();
            List<string> Selecao = new List<string>();
            List<OrdemdeServico> OS = new List<OrdemdeServico>();

            foreach(var item in checkedListBox1.CheckedItems)
            {
                Selecao.Add(item.ToString());
            }
            


            OS = ordem.MostrarPorPeriodo(comboSituacao.Text, dpDe.Value.Date, dpAte.Value.Date, Selecao).ToList();


            foreach(var item in OS)
            {
                DateTime Tempo = new DateTime(0001, 1, 1);
                ListViewItem lv1 = new ListViewItem(item.IdCliente.ToString());
                lv1.SubItems.Add(item.NumeroOS.ToString());
                lv1.SubItems.Add(item.Servico);
                lv1.SubItems.Add(item.Nome);
                lv1.SubItems.Add(item.Situacao);
                lv1.SubItems.Add(item.DataAbertura.ToString("dd/MM/yyyy"));
                if(item.DataExecucao == Tempo)
                {
                    lv1.SubItems.Add(" ");
                }
                lv1.SubItems.Add(item.DataExecucao.ToString());
                listViewRelatorio.Items.Add(lv1);
            }
        }

        private void dpDe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_RelatorioPeriodo_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGerarPDF_Click(object sender, EventArgs e)
        {
            List<OrdemdeServico> ordens = new List<OrdemdeServico>();
            OrdemDAO ordem = new OrdemDAO();

            List<string> Selecao = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                Selecao.Add(item.ToString());
            }

            ordens = ordem.MostrarPorPeriodo(comboSituacao.Text, dpDe.Value.Date, dpAte.Value.Date, Selecao).ToList();

            string pdfRelatorio = "C:\\Users\\ThIaG\\source\\repos\\LP2" + "\\RelatorioPeriodo.pdf";
            FileStream arquivoPDF = new FileStream(pdfRelatorio, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            doc.Open();
            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("RELATÓRIO DE ORDENS DE SERVIÇO POR PERIODO\n\n\n\n\n");


            PdfPTable tabela2 = new PdfPTable(1);
            PdfPTable tabela = new PdfPTable(7);


            tabela.AddCell("ID Cliente");
            tabela.AddCell("Nome");
            tabela.AddCell("Numero O.S");
            tabela.AddCell("Status");
            tabela.AddCell("Servico");
            tabela.AddCell("Data de Abertura");
            tabela.AddCell("Data de Execução");

            foreach (var item in ordens)
            {
                tabela.AddCell(item.IdCliente.ToString());
                tabela.AddCell(item.Nome);
                tabela.AddCell(item.NumeroOS.ToString());
                tabela.AddCell(item.Situacao);
                tabela.AddCell(item.Servico);
                tabela.AddCell(item.DataAbertura.ToString("dd/MM/yyyy"));
                tabela.AddCell(item.DataExecucao.ToString());

            }

            doc.Add(paragrafo);
            doc.Add(tabela);

            doc.Close();

            MessageBox.Show("PDF Gerado com Sucesso!");
            System.Diagnostics.Process.Start("C:\\Users\\ThIaG\\source\\repos\\LP2" + "\\RelatorioPeriodo.pdf");


        }
    }
}
