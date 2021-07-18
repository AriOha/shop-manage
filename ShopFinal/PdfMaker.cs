using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace ShopFinal
{
    class PdfMaker
    {

        public Document document;

        public PdfMaker() : this("untitled.pdf") { }

        public PdfMaker(string filename)
        {
            document = new Document();
            // create pdf file
            PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
            document.Open();
        }



        //document = new Document();
        //// create pdf file
        //iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream("untitled.pdf", FileMode.Create));


        public void AddParagraph(string title)
        {
            document.Add(new Paragraph(title));
        }
        
        //title
        public void AddTitle(string title)
        {
            // create new font
            Font myFont = new Font(iTextSharp.text.Font.FontFamily.COURIER, 18, Font.ITALIC);
            myFont.Color = BaseColor.BLUE;
            document.Add(new Paragraph(title, myFont));
        }

        public void AddSpace()
        {
            document.Add(new Chunk("\n"));
        }

        public void CloseReport()
        {
            document.Close();
            Console.WriteLine("File closed.");
        }

        public void addTable(ListView table)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 50;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;


            //Adding Header row
            foreach (ColumnHeader column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                cell.GrayFill = 0.9F;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (ListViewItem itemRow in table.Items)
            {
                int i;
                for (i = 0; i < itemRow.SubItems.Count; i++)
                {
                    pdfTable.AddCell(itemRow.SubItems[i].Text);
                }
            }

            //Exporting to PDF
            document.Add(pdfTable);
        }
    }
}

