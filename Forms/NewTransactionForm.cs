using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
using DesktopBiblioteca.Interfaces;
using Syncfusion.WinForms.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBiblioteca.Forms
{
    public partial class NewTransactionForm : Form
    {

        private String URI = "http://localhost:5000/api" + "/transaction";

        BusyIndicator busyIndicatorReaders= new BusyIndicator();
        BusyIndicator busyIndicatorBooks = new BusyIndicator();

        BindingSource readersList = new BindingSource();
        BindingSource booksList = new BindingSource();

        public NewTransactionForm(List<Reader> listaReaders, List<Book> listaBooks)
        {
            InitializeComponent();


            //Aqui solo convertimos un listado en dataTable para poder poblar el gridview.
            ListtoDataTableConverter converter = new ListtoDataTableConverter();

            DataTable dtReaders = converter.ToDataTable(listaReaders);
            readersList.DataSource = dtReaders;

            DataTable dtBooks = converter.ToDataTable(listaBooks);
            booksList.DataSource = dtBooks;

        }

        private void dataGridLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridLibros.CurrentRow == null)
            { 
                txtTituloSeleccionado.Text = "";
            }
            else
            {
                txtTituloSeleccionado.Text = dataGridLibros.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void dataGridLectores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridLectores.CurrentRow == null)
            {
                txtLectorSeleccionado.Text = "";
            }
            else
            {
                txtLectorSeleccionado.Text = dataGridLectores.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void txtTituloLibro_TextChanged(object sender, EventArgs e)
        {
         
            this.booksList.Filter = string.Format("title LIKE '%{0}%'", txtTituloLibro.Text);
            dataGridLectores.AllowUserToAddRows = false;
            
        }

        private void txtNombreLector_TextChanged(object sender, EventArgs e)
        {
            
            readersList.Filter = string.Format("name LIKE '%{0}%'", txtNombreLector.Text);
            dataGridLectores.AllowUserToAddRows = false;
        }

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            if (readersList.Count == 0 && booksList.Count == 0)
            {
                busyIndicatorReaders.Show(this.dataGridLectores);
                busyIndicatorBooks.Show(this.dataGridLibros);

            }
            else
            {
                busyIndicatorReaders.Hide();
                busyIndicatorBooks.Hide();

                //Poblamos el datagridview
                dataGridLectores.DataSource = readersList;
                //Poblamos el datagridview
                dataGridLibros.DataSource = booksList;


                //Oculto Filas que no deseo.
                dataGridLibros.Columns["description"].Visible = false; // Telefono
                dataGridLibros.Columns["editorial"].Visible = false; // Direccion
                dataGridLibros.Columns["category"].Visible = false; // Email 
                dataGridLibros.Columns["availability"].Visible = false; // Categoria 
                dataGridLibros.Columns["categoryID"].Visible = false; // Categoria 
                dataGridLibros.Columns["title"].HeaderText = "Titulo";
                dataGridLibros.Columns["author"].HeaderText = "Autor";

                //Oculto Filas que no deseo.
                dataGridLectores.Columns["phone"].Visible = false; // Telefono
                dataGridLectores.Columns["address"].Visible = false; // Direccion
                dataGridLectores.Columns["email"].Visible = false; // Email 
                //Cambio el nombre a las que quedan
                dataGridLectores.Columns["name"].HeaderText = "Nombre";
                dataGridLectores.Columns["dni"].HeaderText = "DNI";

            }
        }

        private void btnCancelNewTransact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetValorCelda(DataGridView dgv, int num)
        {
            string valor = "";

            valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

            return valor;
        }

        private async void btnSaveNewTransact_ClickAsync(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Desea confirmar el prestamo?", "Confirmar", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:

                    //creamos un objeto del tipo transaction
                    Transaction transaction = new Transaction();
                    Reply oReply = new Reply();

                    //Validamos y tomamos los valores de la pantalla para asignarselos a el objeto transaction.

                    if (txtLectorSeleccionado.TextLength > 0 &&
                        txtTituloSeleccionado.TextLength > 0)
                    {
                        transaction.status = (int)StatusEnum.Prestado;
                        transaction.BookID = Convert.ToInt32(GetValorCelda(dataGridLibros, 0));
                        transaction.ReaderID = Convert.ToInt32(GetValorCelda(dataGridLectores, 0));
                        transaction.LoanDate = DateTime.Now;

                        oReply = await Consumer.Execute<Transaction>(URI, ApiHelper.methodHttp.POST, transaction);
                        MessageBox.Show(oReply.StatusCode);

                        
                        if (this.Owner is ITransaction formInterface)
                            formInterface.setNewTransaction(transaction);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deben ingresarse todos los datos del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }

            

        }
    }
}
/*

 */