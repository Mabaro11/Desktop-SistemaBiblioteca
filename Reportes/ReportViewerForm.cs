using DesktopBiblioteca.Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopBiblioteca.Reportes
{
    public partial class ReportViewerForm : Form
    {
        private readonly ReportViewer reportViewer;
        Transaction transaction;
        Reader reader;
        Book book;
        public ReportViewerForm(Transaction transaction,Reader reader, Book book)
        {
            InitializeComponent();

            this.transaction = transaction;
            this.book = book;
            this.reader = reader;

            Text = "Comprobante Prestamo";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            
            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            Report.Load(reportViewer.LocalReport, this.transaction, this.reader, this.book);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
