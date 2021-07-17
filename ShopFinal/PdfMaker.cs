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

        public void AddSpace()
        {
            document.Add(new Chunk("\n"));
        }
        public void SetImage(string imagePath)
        {
            try
            {
                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(imagePath);
                document.Add(pic);

            }
            catch (Exception e)
            {
                document.Add(new Paragraph($"unable to load \"{imagePath}\"."));
                Console.WriteLine("File was not found!");
                Console.WriteLine(e);
            }
        }

        public void SetIntTable(int[,] table)
        {
            iTextSharp.text.pdf.PdfPTable myTable = new iTextSharp.text.pdf.PdfPTable(table.GetLength(1));
            //set all cells alignment
            myTable.HorizontalAlignment = Element.ALIGN_CENTER;

            //create cell
            iTextSharp.text.pdf.PdfPCell myCell = new iTextSharp.text.pdf.PdfPCell();
            myCell.GrayFill = 0.9F;
            myCell.FixedHeight = 20;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            //create table text
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    myCell.Phrase = new Phrase(table[i, j].ToString());
                    myTable.AddCell(myCell);
                }

            }
            document.Add(myTable);
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
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (ColumnHeader column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.Text));
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

