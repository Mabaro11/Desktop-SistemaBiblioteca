using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBiblioteca.Reportes
{
    public class Report
    {

        public static void Load(LocalReport report, Transaction transaction, Reader reader, Book book)
        {

            var parameters = new[] {
                new ReportParameter("Transaccion", transaction.ID.ToString()),
                new ReportParameter("NombreLector", reader.name),
                new ReportParameter("Direccion", reader.address),
                new ReportParameter("Telefono", reader.phone),
                new ReportParameter("Email", reader.email),
                new ReportParameter("Titulo", book.Title),
                new ReportParameter("Autor", book.Author),
                new ReportParameter("Salida", transaction.LoanDate.ToString()),
            };

            using var fs = new FileStream(@"Reportes\Report.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            //report.DataSources.Add(new ReportDataSource("Items", items.ToList()));
            report.SetParameters(parameters);
        }


    }
}
