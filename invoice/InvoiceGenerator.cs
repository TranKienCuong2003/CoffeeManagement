using System;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;
using System.Diagnostics;
using System.Data;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;
using CoffeeManagement.qrCode;
using SystemImage = System.Drawing.Image;
using CoffeeManagement.model;
using CoffeeManagement.utils;

namespace CoffeeManagement.pdf
{
    public class InvoiceGenerator
    {
        #region Singleton pattern
        private static InvoiceGenerator instance;
        public static InvoiceGenerator Instance
        {
            get
            {
                if (instance == null)
                    instance = new InvoiceGenerator();
                return instance;
            }
            private set { instance = value; }
        }
        #endregion


        private Document document;   
        private TextFrame addressFrame;
        private Table table;

        private const string DEFAULT_DIR = "D:/invoices";

        private const string INVOICE_PREFIX = "invoice_";
        private const string INVOICE_SUFFIX = ".pdf";

        private const int QR_CODE_Y_FIXED = 196;
        private const int DEFAULT_ROW_HEIGHT = 16;

        private int CurrentTableHeight = 0;

        public void GenerateInvoice(BillPayload payload, Bank bank, string billNo)
        {
            this.document = new Document();

            DefineStyles();

            CreatePage(billNo);

            FillContent(payload);

            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = this.document;
            pdfRenderer.RenderDocument();
            PdfDocument pdfDocument = pdfRenderer.PdfDocument;

            InsertImage(pdfDocument, bank, payload.FinalPrice);

            CreateDirIfNotExist();

            string filePath = Path.Combine(DEFAULT_DIR, INVOICE_PREFIX + billNo + INVOICE_SUFFIX);
            pdfRenderer.PdfDocument.Save(filePath);
            Process.Start(filePath);
        }

        private void CreateDirIfNotExist()
        {
            if (!Directory.Exists(DEFAULT_DIR))
            {
                Directory.CreateDirectory(DEFAULT_DIR);
            }
        }

        private void DefineStyles()
        {
            Style style = this.document.Styles["Normal"];
           
            style.Font.Name = "Verdana";

            style = this.document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("13cm", TabAlignment.Right);

            style = this.document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 12;

            style = this.document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("13cm", TabAlignment.Right);
        }

        private void CreatePage(string billNo)
        {
            // Each MigraDoc document needs at least one section.
            Section section = this.document.AddSection();

            // Add the print date field
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Format.SpaceAfter = Unit.FromCentimeter(0.5);
            paragraph.Style = "Reference";
            paragraph.AddFormattedText("HOÁ ĐƠN THANH TOÁN", TextFormat.Bold);
            paragraph.AddTab();
            paragraph.AddText("Hà Nội, ");
            paragraph.AddDateField("dd-MM-yyyy");

            paragraph = section.AddParagraph();
            paragraph.Style = "Reference";
            paragraph.Format.SpaceBefore = Unit.FromCentimeter(0.5);
            paragraph.AddText("   Mã hóa đơn: " + billNo);

            paragraph = section.AddParagraph();
            paragraph.Style = "Reference";
            paragraph.Format.SpaceBefore = Unit.FromCentimeter(0.5);
            paragraph.AddText("   Nhân viên: " + Program.context.LoginAccount.DisplayName);

            paragraph = section.AddParagraph();
            paragraph = section.AddParagraph();

            // Create the item table
            this.table = section.AddTable();
            this.table.Style = "Table";

            this.table.Borders.Color = Colors.White;
            this.table.Borders.Width = 0.25;
            this.table.Borders.Left.Width = 0.5;
            this.table.Borders.Right.Width = 0.5;
            this.table.Rows.LeftIndent = 0;

            Column column = this.table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = this.table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = this.table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            Row row = table.AddRow();

            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
           

            row.Cells[0].AddParagraph("TT");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;

            row.Cells[1].AddParagraph("Tên món");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph("Số lượng");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[3].AddParagraph("Đơn giá");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[4].AddParagraph("Thành tiền");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[4].VerticalAlignment = VerticalAlignment.Bottom;

            this.table.SetEdge(0, 0, 5, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);
        }

        private void FillContent(BillPayload payload)
        {
            int stt = 0;

            payload.BillInfos.ForEach(bi =>
            {
                stt++;
                CurrentTableHeight += DEFAULT_ROW_HEIGHT;

                Row dataRow = this.table.AddRow();

                dataRow.TopPadding = 2;
                dataRow.BottomPadding = 2;

                // STT
                dataRow.Cells[0].AddParagraph(stt.ToString());

                // Tên món
                dataRow.Cells[1].AddParagraph(bi.DrinkName);
                dataRow.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                dataRow.Cells[1].VerticalAlignment = VerticalAlignment.Center;

                // Số lượng
                dataRow.Cells[2].AddParagraph(bi.Quantity.ToString());
                dataRow.Cells[2].VerticalAlignment = VerticalAlignment.Center;

                // Đơn giá
                dataRow.Cells[3].AddParagraph(bi.DrinkPrice.ToString());
                dataRow.Cells[3].VerticalAlignment = VerticalAlignment.Center;

                // Thành tiền
                dataRow.Cells[4].AddParagraph(bi.TotalPrice.ToString());
                dataRow.Cells[4].VerticalAlignment = VerticalAlignment.Center;

                this.table.SetEdge(0, this.table.Rows.Count - 2, 5, 2, Edge.Box, BorderStyle.Single, 0.75);
            });

            Row row = this.table.AddRow();
            row.Borders.Visible = false;

            row = this.table.AddRow();
            row.Borders.Visible = false;

            row = this.table.AddRow();
            row.Borders.Visible = false;


            row = this.table.AddRow();
            row.Cells[0].AddParagraph("Thành tiền");
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 3;
            row.Cells[4].AddParagraph(PriceUtils.ToPriceString(payload.TotalPrice));
           
           
            row = this.table.AddRow();
            row.Cells[0].AddParagraph("Giảm giá");
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 3;
            row.Cells[4].AddParagraph(PriceUtils.ToPercentString(payload.Discount));

            row = this.table.AddRow();
            row.Cells[0].AddParagraph("Tổng cộng");
            row.Cells[0].Borders.Visible = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Right;
            row.Cells[0].MergeRight = 3;
            row.Cells[4].AddParagraph(PriceUtils.ToPriceString(payload.FinalPrice));

            this.table.SetEdge(4, this.table.Rows.Count - 4, 1, 4, Edge.Box, BorderStyle.Single, 0.75);
        }

        private void InsertImage(PdfDocument pdfDocument, Bank bank, decimal amount)
        {
            PdfPage page = pdfDocument.Pages[pdfDocument.PageCount - 1];

            XGraphics gfx = XGraphics.FromPdfPage(page);

            SystemImage imageInstance = QRCodeGenerator.GenerateQRCode(bank, amount); 

            using (MemoryStream memoryStream = new MemoryStream())
            {
                imageInstance.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Position = 0;

                XImage xImage = XImage.FromStream(memoryStream);

                int imageWidth = 200;
                int imageHeight = 200;
                double imageX = 60;
                double imageY = QR_CODE_Y_FIXED + CurrentTableHeight;

                gfx.DrawImage(xImage, imageX, imageY, imageWidth, imageHeight);
            }

            // reset current table height
            this.CurrentTableHeight = 0;
        }

#if true
        // RGB colors
        readonly static Color TableBorder = new Color(81, 125, 192);
        readonly static Color TableBlue = new Color(235, 240, 249);
        readonly static Color TableGray = new Color(242, 242, 242);
#else
    // CMYK colors
    readonly static Color tableBorder = Color.FromCmyk(100, 50, 0, 30);
    readonly static Color tableBlue = Color.FromCmyk(0, 80, 50, 30);
    readonly static Color tableGray = Color.FromCmyk(30, 0, 0, 0, 100);
#endif
    }
}