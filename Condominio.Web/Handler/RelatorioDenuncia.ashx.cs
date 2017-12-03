using Condominio.Model.QueryModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Condominio.Web.Handler
{

    public class CabecalhoDenuncia : PdfPageEventHelper
    {
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            var totalWidth = document.PageSize.Width - 50f;
            var headerFont = new Font(Font.FontFamily.HELVETICA, 12f, Font.BOLD, BaseColor.BLACK);

            var pdfTable = new PdfPTable(1)
            {
                TotalWidth = totalWidth,
                LockedWidth = true
            };


            var largura = new[]
            {
                totalWidth / 1
            };

            pdfTable.SetWidths(largura);
            pdfTable.SpacingBefore = 5f;
            pdfTable.KeepTogether = false;

            var cell = new PdfPCell(new Paragraph("CONDOTECH",
                new Font(Font.FontFamily.HELVETICA, 16f, Font.BOLD, BaseColor.BLACK)))
            {
                PaddingTop = 8f,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = Rectangle.NO_BORDER
            };
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Sistema de Gerenciamento para Condomínios",
                new Font(Font.FontFamily.HELVETICA, 12f, Font.NORMAL, BaseColor.BLACK)))
            {
                PaddingTop = 8f,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = Rectangle.NO_BORDER
            };
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Denúncias por Período", headerFont))
            {
                PaddingTop = 10f,
                HorizontalAlignment = Element.ALIGN_CENTER,
                Border = Rectangle.BOTTOM_BORDER
            };

            pdfTable.AddCell(cell);
            document.Add(pdfTable);

            pdfTable = new PdfPTable(5)
            {
                TotalWidth = totalWidth,
                LockedWidth = true
            };

            largura = new[]
            {
                totalWidth - 350f,
                totalWidth - 100f,
                totalWidth - 200f,
                totalWidth ,
                totalWidth
            };


            pdfTable.SetWidths(largura);
            pdfTable.SpacingBefore = 5f;
            pdfTable.KeepTogether = false;

            cell = new PdfPCell(new Paragraph("Código", new Font(headerFont)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Border = Element.ALIGN_LEFT,
            };
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Denunciante", new Font(headerFont)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Border = Element.ALIGN_LEFT,
            };
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Celular", new Font(headerFont)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Border = Element.ALIGN_LEFT,
            };
            pdfTable.AddCell(cell);

            cell = new PdfPCell(new Paragraph("Descrição", new Font(headerFont)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Border = Element.ALIGN_LEFT,
            };
            pdfTable.AddCell(cell);


            cell = new PdfPCell(new Paragraph("Data", new Font(headerFont)))
            {
                HorizontalAlignment = Element.ALIGN_LEFT,
                Border = Element.ALIGN_LEFT,
            };
            pdfTable.AddCell(cell);
            document.Add(pdfTable);
        }


    }


    public class RelatorioDenuncia : IHttpHandler
    {
        public static IEnumerable<QueryDenuncia> RelDenuncia;

        public RelatorioDenuncia()
        {

        }

        public RelatorioDenuncia(IEnumerable<QueryDenuncia> relDenuncia)
        {
            RelDenuncia = relDenuncia;
        }

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                var bodyFont = new Font(Font.FontFamily.HELVETICA, 10f, Font.BOLD, BaseColor.BLACK);
                var document = new Document(PageSize.A4);
                document.SetMargins(5f, 5f, 15f, 15f);
                var totalWidth = document.PageSize.Width - 50f;

                using (var memoryStream = new MemoryStream())
                {
                    var writer = PdfWriter.GetInstance(document, memoryStream);

                    writer.PageEvent = new CabecalhoDenuncia();
                    document.Open();

                    foreach (var item in RelDenuncia)
                    {
                        var tablePdf = new PdfPTable(5)
                        {
                            TotalWidth = totalWidth,
                            LockedWidth = true
                        };

                        var largura = new[]
                        {
                         totalWidth - 300f,
                         totalWidth,
                         totalWidth - 200f,
                         totalWidth + 400f,
                         totalWidth
                        };


                        tablePdf.SetWidths(largura);
                        tablePdf.SpacingBefore = 5f;
                        tablePdf.KeepTogether = false;



                        #region Codigo

                        var cell =
                            new PdfPCell(new Paragraph(item.IdDenuncia.ToString(),
                                new Font(bodyFont)))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = Rectangle.NO_BORDER,
                                PaddingTop = 5f
                            };
                        tablePdf.AddCell(cell);

                        #endregion

                        #region Nome

                        cell =
                            new PdfPCell(new Paragraph(item.Nome,
                                new Font(bodyFont)))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = Rectangle.NO_BORDER,
                                PaddingTop = 5f
                            };
                        tablePdf.AddCell(cell);

                        #endregion

                        #region Celular

                        cell =
                            new PdfPCell(new Paragraph(item.Celular,
                                new Font(bodyFont)))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = Rectangle.NO_BORDER,
                                PaddingTop = 5f
                            };
                        tablePdf.AddCell(cell);

                        #endregion

                        #region Descricao

                        cell =
                            new PdfPCell(new Paragraph(item.Descricao,
                                new Font(bodyFont)))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = Rectangle.NO_BORDER,
                                PaddingTop = 5f
                            };
                        tablePdf.AddCell(cell);

                        #endregion

                        #region Data

                        cell =
                            new PdfPCell(new Paragraph(item.DataDenuncia.ToString("dd/MM/yyyy"),
                                new Font(bodyFont)))
                            {
                                HorizontalAlignment = Element.ALIGN_LEFT,
                                Border = Rectangle.NO_BORDER,
                                PaddingTop = 5f
                            };
                        tablePdf.AddCell(cell);

                        #endregion

                        document.Add(tablePdf);
                    }

                    document.Close();
                    writer.Close();
                    context.Response.Clear();
                    context.Response.ContentType = "application/pdf";
                    context.Response.AddHeader("content-disposition", "inline;filename=DenunciaPeriodo.pdf");
                    context.Response.OutputStream.Write(memoryStream.GetBuffer(), 0, memoryStream.GetBuffer().Length);
                    context.Response.OutputStream.Flush();
                    context.Response.OutputStream.Close();
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public bool IsReusable => false;
    }
}