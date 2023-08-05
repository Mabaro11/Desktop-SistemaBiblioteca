using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
using DesktopBiblioteca.Interfaces;
using DesktopBiblioteca.Reportes;
using Syncfusion.WinForms.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopBiblioteca.Forms
{
    public partial class TransactionsForm : Form, ITransaction
    {
        private readonly string URI = Program.BaseUrl;

        private string URLTransactions;
        private string URLBooks;
        private string URLReaders;

        BindingSource filteredList = new BindingSource();

        List<Transaction> listadoTransaction = new List<Transaction>();
        List<Reader> listadoReader = new List<Reader>();
        List<Book> listadoBook = new List<Book>();

        BusyIndicator busyIndicator = new BusyIndicator();
        public TransactionsForm()
        {
            InitializeComponent();
            this.URLTransactions = URI + "/transaction";
            this.URLBooks = URI + "/book/all";
            this.URLReaders = URI + "/reader/all";
        }

        private async void GetData()
        {
            busyIndicator.Show(this.dataGridTransactions);
            DisableControls();

            Reply oReply = new Reply();

            oReply = await Consumer.Execute(URLTransactions, methodHttp.GET, listadoTransaction);
            this.listadoTransaction = (List<Transaction>)oReply.Data;
            CheckReply(oReply);

            oReply = await Consumer.Execute(URLReaders, methodHttp.GET, listadoReader);
            this.listadoReader = (List<Reader>)oReply.Data;
            CheckReply(oReply);

            oReply = await Consumer.Execute(URLBooks, methodHttp.GET, listadoBook);
            this.listadoBook = (List<Book>)oReply.Data;
            CheckReply(oReply);

            busyIndicator.Hide();
            EnableControls();

            setBindingList();



            if (oReply.Data != null)
            {
            }

        }

        //Este metodo agrega una transaccion a la lista de transacciones
        //una vez que se guarda una desde newtransactionform
        public void setNewTransaction(Transaction transaction)
        {
            listadoTransaction.Add(transaction);
            setBindingList();
            ImprimirReporte(transaction.ID);
        }

        private void setBindingList()
        {
            var result = listadoTransaction.Select(t => new
            {
                ID = t.ID,
                Libro = listadoBook.Where(b => b.ID.Equals(t.BookID)).First().Title,
                Lector = listadoReader.Where(r => r.id.Equals(t.ReaderID)).First().name,
                Prestamo = t.LoanDate.ToString(),
                Devolucion = t.ReturnDate.ToString(),

            });

            //Aqui solo convertimos un listado en dataTable para poder poblar el gridview.
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(result.ToList());

            filteredList.DataSource = dt;
            dataGridTransactions.AllowUserToAddRows = false;
        }

        private void EnableControls()
        {
            btnPrestamo.Enabled = true;
            btnEliminar.Enabled = true;
            btnDevolucion.Enabled = true;
            btnPrint.Enabled = true;

        }
        private void DisableControls()
        {
            btnPrestamo.Enabled = false;
            btnDevolucion.Enabled = false;
            btnEliminar.Enabled = false;
            btnPrint.Enabled = false;
        }


        private void CheckReply(Reply oReply)
        {
            if (oReply.StatusCode != "OK")
            {
                if (MessageBox.Show(oReply.StatusCode, null, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            this.dataGridTransactions.DataSource = filteredList;
            GetData();
            radButtLector.Checked = true;//seteo el boton de lector por defecto.
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (txtBuscar.Text.Length == 0)
            {
                filteredList.RemoveFilter();
            }
            else
            {

                var filter = "";
                if (radButtLector.Checked) filter = string.Format("Lector LIKE '%{0}%'", txtBuscar.Text);
                if (radButtLibro.Checked) filter = string.Format("Libro LIKE '%{0}%'", txtBuscar.Text);

                filteredList.Filter = filter;
                dataGridTransactions.AllowUserToAddRows = false;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void radButtLector_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtLector.Checked)
            {
                radButtLibro.Checked = false;
                clearBusqueda();
            }
        }

        private void radButtLibro_CheckedChanged(object sender, EventArgs e)
        {
            if (radButtLibro.Checked)
            {
                radButtLector.Checked = false;
                clearBusqueda();
            }
        }

        private void clearBusqueda()
        {
            txtBuscar.Text = "";
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewTransactionForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano

                NewTransactionForm chForm = frm as NewTransactionForm;
                chForm.Show(this);
                return;

            }
            else
            {
                //sino existe la instancia se crea una nueva
                NewTransactionForm newFrm = new NewTransactionForm(listadoReader, listadoBook);
                newFrm.Owner = this;
                newFrm.Show();
            }


        }

        public static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private async void btnDevolucion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea confirmar la devolucion?", "Confirmar", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        if (dataGridTransactions.CurrentRow != null)
                        {
                            Reply oReply = new Reply();

                            //creamos un objeto del tipo transaction
                            Transaction transaction = listadoTransaction.Find(t => t.ID == Convert.ToInt32(GetValorCelda(dataGridTransactions, 0)));

                            if (transaction.ReaderID != 0)
                            {
                                transaction.status = (int)StatusEnum.Devuelto;
                                transaction.ReturnDate = DateTime.Now;

                                oReply = await Consumer.Execute(URLTransactions + "/" + transaction.ID, methodHttp.PUT, transaction);
                                MessageBox.Show(oReply.StatusCode);

                                listadoTransaction.Where(t => t.ID == transaction.ID).Select(S => { S.ReturnDate = transaction.ReturnDate; return S; }).ToList();
                                setBindingList();
                            }
                            else
                            {
                                MessageBox.Show("Transaccion resuelta.", "Error");
                            }


                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionarse una columna", "Error");
                        }
                    }
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void chkboxTransCompletas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxTransCompletas.Checked)
            {

                var filter = "";
                if (chkboxTransCompletas.Checked) filter = string.Format("Devolucion Is Null Or Trim(Devolucion) = ''");
                filteredList.Filter = filter;

            }
            else
            {
                Search();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea confirmar la eliminacion?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Transaction transaction = new Transaction();
                Reply oReply = new Reply();
                var transactionId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells[0].Value);

                oReply = await Consumer.Execute<Transaction>(URLTransactions + $"/{transactionId}", methodHttp.DELETE, transaction);

                MessageBox.Show(oReply.StatusCode.ToString());
                filteredList.RemoveCurrent();

            }


        }

        private async void ImprimirReporte(int transactionId)
        {
            DialogResult respuestaComprobante = MessageBox.Show($"¿Desea imprimir un comprobante del prestamo?", "Confirmar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuestaComprobante == DialogResult.Yes)
            {

                Transaction transaction = new Transaction();
                Reply oReply = new Reply();

                oReply = await Consumer.Execute(URLTransactions + $"/{transactionId}", methodHttp.GET, transaction);

                transaction = (Transaction)oReply.Data;

                Reader reader = listadoReader.Where(r => r.id.Equals(transaction.ReaderID)).First();
                Book book = listadoBook.Where(r => r.ID.Equals(transaction.BookID)).First();

                ReportViewerForm report = new ReportViewerForm(transaction, reader, book);
                report.Show();

            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var transactionId = Convert.ToInt32(dataGridTransactions.CurrentRow.Cells[0].Value);
            ImprimirReporte(transactionId);
        }
    }
}
