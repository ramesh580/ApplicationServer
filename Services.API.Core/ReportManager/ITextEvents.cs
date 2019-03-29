using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

namespace Services.API.Core.ReportManager
{
    public class ITextEvents: PdfPageEventHelper
    {
    PdfContentByte cb;
    PdfTemplate headerTemplate, footerTemplate;
    BaseFont bf = null;
    DateTime PrintTime = DateTime.Now;
    private string _header;
    private string _footer;

    public string Header
    {
        get { return _header; }
        set { _header = value; }
    }

    public string Footer
    {
        get { return _footer; }
        set { _footer = value; }
    }

    public override void OnOpenDocument(PdfWriter writer, Document document)
    {
        try
        {
            PrintTime = DateTime.Now;
            bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb = writer.DirectContent;
            headerTemplate = cb.CreateTemplate(100, 100);
            footerTemplate = cb.CreateTemplate(50, 50);
        }
        catch (DocumentException de)
        {
        }
        catch (System.IO.IOException ioe)
        {
        }
    }

    public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, iTextSharp.text.Document document)
    {
        base.OnEndPage(writer, document);
        iTextSharp.text.Font baseFontNormal = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 12f,
            iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.Black);
        iTextSharp.text.Font baseFontBig = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 12f,
            iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.Black);
        Phrase p1Header = new Phrase(_header, baseFontNormal);
        PdfPTable pdfTab = new PdfPTable(3);
        PdfPCell pdfCell1 = new PdfPCell();
        PdfPCell pdfCell2 = new PdfPCell(p1Header);
        PdfPCell pdfCell3 = new PdfPCell();
        string text = _footer;

        {
            cb.BeginText();
            cb.SetFontAndSize(bf, 12);
            cb.SetTextMatrix(document.PageSize.GetRight(300), document.PageSize.GetBottom(30));
            cb.ShowText(text);
            cb.EndText();
            float len = bf.GetWidthPoint(text, 12);
            cb.AddTemplate(footerTemplate, document.PageSize.GetRight(180) + len, document.PageSize.GetBottom(30));
        }

        PdfPCell pdfCell4 = new PdfPCell();
        //PdfPCell pdfCell5 = new PdfPCell(new Phrase("Date:" + PrintTime.ToString(), baseFontBig));
        PdfPCell pdfCell5 = new PdfPCell();
        PdfPCell pdfCell6 = new PdfPCell();
        //PdfPCell pdfCell7 = new PdfPCell(new Phrase("TIME:" + string.Format("{0:t}", DateTime.Now), baseFontBig));
        PdfPCell pdfCell7 = new PdfPCell();

        pdfCell1.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell2.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell3.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell4.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell5.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell6.HorizontalAlignment = Element.ALIGN_CENTER;
        pdfCell7.HorizontalAlignment = Element.ALIGN_CENTER;

        pdfCell2.VerticalAlignment = Element.ALIGN_BOTTOM;
        pdfCell3.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell4.VerticalAlignment = Element.ALIGN_TOP;
        pdfCell5.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell6.VerticalAlignment = Element.ALIGN_MIDDLE;
        pdfCell7.VerticalAlignment = Element.ALIGN_MIDDLE;

        pdfCell4.Colspan = 3;

        pdfCell1.Border = 0;
        pdfCell2.Border = 0;
        pdfCell3.Border = 0;
        pdfCell4.Border = 0;
        pdfCell5.Border = 0;
        pdfCell6.Border = 0;
        pdfCell7.Border = 0;

        pdfTab.AddCell(pdfCell1);
        pdfTab.AddCell(pdfCell2);
        pdfTab.AddCell(pdfCell3);
        pdfTab.AddCell(pdfCell4);
        pdfTab.AddCell(pdfCell5);
        pdfTab.AddCell(pdfCell6);
        pdfTab.AddCell(pdfCell7);

        pdfTab.TotalWidth = document.PageSize.Width - 80f;
        pdfTab.WidthPercentage = 70;

        pdfTab.WriteSelectedRows(0, -1, 40, document.PageSize.Height - 30, writer.DirectContent);

        cb.MoveTo(40, document.PageSize.Height - 70);
        cb.LineTo(document.PageSize.Width - 40, document.PageSize.Height - 70);
        cb.Stroke();

        cb.MoveTo(40, document.PageSize.GetBottom(50));
        cb.LineTo(document.PageSize.Width - 40, document.PageSize.GetBottom(50));
        cb.Stroke();
    }
    }
}