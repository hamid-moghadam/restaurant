using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Extensions
{
    public class PDFConverter
    {
        private string path;
        private DataTable dt;


        public PDFConverter(string path,DataTable dataTable)
        {
            this.path = path;
            this.dt = dataTable;

        }

        public void Generate(List<Factor> factors)
        {
            Document document = new Document();


            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();
            foreach (var factor in factors)
            {
                Paragraph p = new Paragraph(factor.ToString());
                document.Add(p);
                RomanList romanList = new RomanList(true, 20);
                romanList.IndentationLeft = 15;
                foreach (var detail in factor.FactorDetails)
                {
                    romanList.Add(detail.ToString());
                }
                document.Add(romanList);
            }
            /*iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[] { 2f, 2f,2f};

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Factors"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {

                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    table.AddCell(new Phrase(r[0].ToString(), font5));
                    table.AddCell(new Phrase(r[1].ToString(), font5));
                    table.AddCell(new Phrase(r[2].ToString(), font5));
                    table.AddCell(new Phrase(r[3].ToString(), font5));
                }
            }*/
            //document.Add(table);
            document.Close();
        }
    }
}
