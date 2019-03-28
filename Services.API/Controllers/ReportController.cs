using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.API.Core.ReportManager;

namespace Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    { 
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        public ReportController(Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _hostingEnvironment = env;
        }

        [HttpPost]
        public string Post()
        {
            IFormFile image = ((FormCollection) HttpContext.Request.Form).Files[0];
            string header = Convert.ToString(HttpContext.Request.Form["header"]);
            string footer = Convert.ToString(HttpContext.Request.Form["footer"]);

            string parentpath = _hostingEnvironment.ContentRootPath;
            string pdfFolder = parentpath + @"\PDFs\";

            if (!Directory.Exists(pdfFolder))
            {
                Directory.CreateDirectory(pdfFolder);
            }

            Document document = new Document();
            string fileName = Guid.NewGuid() + ".pdf";
            string pdfFile = pdfFolder + fileName;
            FileStream fs = new FileStream(pdfFile, FileMode.Create);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, fs);
            ITextEvents iTextEvents = new ITextEvents();
            iTextEvents.Header = header;
            iTextEvents.Footer = footer;
            pdfWriter.PageEvent = iTextEvents;
            document.Open();

            byte[] fileBytes = null;
            using (var ms = new MemoryStream())
            {
                image.CopyTo(ms);
                fileBytes = ms.ToArray();
            }

            Image pic = Image.GetInstance(fileBytes);
            pic.SetAbsolutePosition(50, 300);
            pic.ScaleAbsolute(400f, 300f);

            PdfPTable table = new PdfPTable(3);
            table.TotalWidth = 500F;
            PdfPCell cell = new PdfPCell();
            cell.Colspan = 3;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);
            table.AddCell("Row 1, Data 1");
            table.AddCell("Row 1, Data 2");
            table.AddCell("Row 1, Data 3");

            cell = new PdfPCell();
            cell.Colspan = 3;
            table.AddCell("Row 2, Data 1");
            table.AddCell("Row 2, Data 2");
            table.AddCell("Row 2, Data 3");

            PdfContentByte cb = pdfWriter.DirectContent;
            BaseFont f_cn = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            cb.BeginText();
            cb.SetFontAndSize(f_cn, 9);
            table.WriteSelectedRows(0, -1, 50, 700, cb);
            cb.EndText();

            document.Add(pic);
            document.Close();
            fs.Dispose();

            return fileName;
        }
    }
}