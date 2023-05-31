
using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
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
    public partial class BooksForm : Form
    {

        private readonly String URI = "http://localhost:5000/api";

        private String URL;
        private String URLCategories;

        BindingSource booksList = new BindingSource();
        BindingSource categoriesList = new BindingSource();

        BusyIndicator busyIndicator = new BusyIndicator();

        int idBookModificado;
        public BooksForm()
        {
            InitializeComponent();
            this.URL = URI + "/book";
            this.URLCategories = URI + "/category";

        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            GetBooks();
        }

        private async void GetBooks()
        {
            busyIndicator.Show(this.dataGridBooks);
            //Creamos el listado de Books a llenar
            DataTable listado = new DataTable();
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //Poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute(URL, methodHttp.GET, listado);
            busyIndicator.Hide();

            if (oReply.StatusCode != "OK")
            {
                if (MessageBox.Show(oReply.StatusCode, null, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            //Poblamos el datagridview
            booksList.DataSource = oReply.Data;

            if (oReply.Data != null)
            {
                //Oculto Filas que no deseo.
                dataGridBooks.Columns["description"].Visible = false; // Telefono
                dataGridBooks.Columns["editorial"].Visible = false; // Direccion
                dataGridBooks.Columns["category"].Visible = false; // Email 
                dataGridBooks.Columns["quantity"].Visible = false; // Categoria 
                dataGridBooks.Columns["categoryID"].Visible = false; // Categoria 

            }

        }

        private async void GetCategories()
        {
            
            List<Category> listado = new List<Category>();
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //Poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute(URLCategories, methodHttp.GET, listado);
            

            if (oReply.StatusCode != "OK")
            {
                if (MessageBox.Show(oReply.StatusCode, null, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            //Poblamos el datagridview
            cboCategoria.DataSource = oReply.Data;
            cboCategoria.DisplayMember = "name";
            cboCategoria.ValueMember = "id";

        }
        private void dataGridBooks_SelectionChanged(object sender, EventArgs e)
        {
            
                if (booksList.Count > 0)
                {
                    //Con este metodo del datagridview logro que se carguen en los los siguientes txt los valores seleccionados.

                    txtTitulo.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells["title"].Value); //Titlulo
                    txtDescripcion.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells["description"].Value); //Descripcion
                    txtEditorial.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells["editorial"].Value); //Editorial
                    txtAutor.Text = Convert.ToString(dataGridBooks.CurrentRow.Cells["author"].Value); //Autor
                    cboCategoria.SelectedValue = Convert.ToInt32(dataGridBooks.CurrentRow.Cells["categoryID"].Value);
                }
                else
                {
                    CancelControls();
                }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.idBookModificado = 0;
            SetNewBookControls();
            txtTitulo.Select();
        }
        private void SetNewBookControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtTitulo.Clear();
            txtTitulo.ReadOnly = false;

            txtDescripcion.Clear();
            txtDescripcion.ReadOnly = false;

            txtEditorial.Clear();
            txtEditorial.ReadOnly = false;

            txtAutor.Clear();
            txtAutor.ReadOnly = false;

            cboCategoria.Text = "";
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDown;

            dataGridBooks.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnCategory.Enabled=false;
        }
        private void SetUpdateBookControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtTitulo.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            txtEditorial.ReadOnly = false;
            txtAutor.ReadOnly = false;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDown;

            dataGridBooks.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnCategory.Enabled = false;
        }
        private void CancelControls()
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;

            txtTitulo.Clear();
            txtTitulo.ReadOnly = true;

            txtDescripcion.Clear();
            txtDescripcion.ReadOnly = true;

            txtEditorial.Clear();
            txtEditorial.ReadOnly = true;

            txtAutor.Clear();
            txtAutor.ReadOnly = true;

            cboCategoria.Text = "";
            cboCategoria.DropDownStyle = ComboBoxStyle.Simple;

            dataGridBooks.Enabled = true;
            if (booksList.Count > 0) dataGridBooks.Rows[0].Selected = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //creamos un objeto del tipo socio
            Book book = new Book();
            Reply oReply = new Reply();

            //Validamos y tomamos los valores de la pantalla para asignarselos a el objeto socio.

            if (txtAutor.TextLength > 0 &&
                txtDescripcion.TextLength > 0 &&
                txtTitulo.TextLength > 0 &&
                //txtCategoria.TextLength > 0 &&
                txtEditorial.TextLength > 0)
            {
                book.Title = txtTitulo.Text;
                book.CategoryID = (int)cboCategoria.SelectedValue;
                book.Description = txtDescripcion.Text;
                book.Author = txtAutor.Text;
                book.Editorial = txtEditorial.Text;

                if (this.idBookModificado == 0)
                {
                    //agregamos el book a la tabla readers
                    oReply = await Consumer.Execute<Book>(URL, ApiHelper.methodHttp.POST, book);

                    MessageBox.Show(oReply.StatusCode);
                }
                else
                {
                    book.ID = this.idBookModificado;
                    oReply = await Consumer.Execute<Book>(URL + $"/{book.ID}", ApiHelper.methodHttp.PUT, book);

                    MessageBox.Show(oReply.StatusCode);

                }
                CancelControls();
                GetBooks();
            }
            else
            {
                MessageBox.Show("Deben ingresarse todos los datos del libro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelControls();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            Reply oReply = new Reply();
            var bookId = Convert.ToInt32(dataGridBooks.CurrentRow.Cells[0].Value);

            oReply = await Consumer.Execute<Book>(URL + $"/{bookId}", ApiHelper.methodHttp.DELETE, book);

            MessageBox.Show(oReply.StatusCode);
            GetBooks();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.idBookModificado = Convert.ToInt32(dataGridBooks.CurrentRow.Cells[0].Value);
            SetUpdateBookControls();
            txtTitulo.Select();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetBooks();
            this.dataGridBooks.DataSource = booksList;
            
        }

        private void cboCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            booksList.Filter = string.Format("title LIKE '%{0}%'", txtBuscar.Text);
            dataGridBooks.AllowUserToAddRows = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CategoriesForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano

                CategoriesForm chForm = frm as CategoriesForm;
                chForm.ShowDialog();
                return;

            }
            else
            {
                //sino existe la instancia se crea una nueva
                CategoriesForm newFrm = new CategoriesForm();
                newFrm.ShowDialog(this);
            }
        }
    }
}
