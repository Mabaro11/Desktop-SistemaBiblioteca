using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.WinForms.Core.Utils;


namespace DesktopBiblioteca.Forms
{
    public partial class CategoriesForm : Form
    {

        private readonly string URI = Program.BaseUrl;
        private string URLCategories;

        BindingSource categoriesList = new BindingSource();

        //Creamos el listado de Categorias a llenar
        DataTable listado = new DataTable();

        BusyIndicator busyIndicator = new BusyIndicator();

        int idCategoryModificado;
        public CategoriesForm()
        {
            InitializeComponent();
            this.URLCategories = URI + "/category";
        }

        private async void GetCategories()
        {

            busyIndicator.Show(this.dataGridCategorias);
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //Poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute(URLCategories, methodHttp.GET, listado);
            busyIndicator.Hide();

            if (oReply.StatusCode != "OK")
            {
                if (MessageBox.Show(oReply.StatusCode, null, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            //Poblamos el datagridview
            categoriesList.DataSource = oReply.Data;
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            GetCategories();
            this.dataGridCategorias.DataSource = categoriesList;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            categoriesList.Filter = string.Format("Name LIKE '%{0}%'", txtBuscar.Text);
            dataGridCategorias.AllowUserToAddRows = false;
        }

        private void dataGridCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (categoriesList.Count > 0)
            {
                //Con este metodo del datagridview logro que se carguen en los los siguientes txt los valores seleccionados.
                txtTitulo.Text = Convert.ToString(dataGridCategorias.CurrentRow.Cells["Name"].Value); //Titlulo
            }
            else
            {
                txtTitulo.Text = "";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.idCategoryModificado = 0;
            SetNewCategoryControls();
            txtTitulo.Select();
        }
        private void SetNewCategoryControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtTitulo.Clear();
            txtTitulo.ReadOnly = false;

            dataGridCategorias.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //creamos un objeto del tipo socio
            Category category = new Category();
            Reply oReply = new Reply();

            //Validamos y tomamos los valores de la pantalla para asignarselos a el objeto category.
            if (txtTitulo.TextLength > 0)
            {
                category.Name = txtTitulo.Text;

                if (this.idCategoryModificado == 0)
                {
                    //agregamos el book a la tabla readers
                    busyIndicator.Show(this);
                    oReply = await Consumer.Execute<Category>(URLCategories, methodHttp.POST, category);
                    busyIndicator.Hide();

                    MessageBox.Show(oReply.StatusCode);
                }
                else
                {
                    category.ID = this.idCategoryModificado;
                    oReply = await Consumer.Execute<Category>(URLCategories + $"/{category.ID}", methodHttp.PUT, category);

                    MessageBox.Show(oReply.StatusCode);

                }
                CancelControls();
                GetCategories();
            }
            else
            {
                MessageBox.Show("Deben ingresarse todos los datos de la categoria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void CancelControls()
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;

            txtTitulo.Clear();
            txtTitulo.ReadOnly = true;

            dataGridCategorias.Enabled = true;
            if (categoriesList.Count > 0) dataGridCategorias.Rows[0].Selected = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            Reply oReply = new Reply();
            var categoryId = Convert.ToInt32(dataGridCategorias.CurrentRow.Cells[0].Value);

            oReply = await Consumer.Execute<Category>(URLCategories + $"/{categoryId}", methodHttp.DELETE, category);

            MessageBox.Show(oReply.StatusCode);
            GetCategories();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.idCategoryModificado = Convert.ToInt32(dataGridCategorias.CurrentRow.Cells[0].Value);
            SetUpdateBookControls();
            txtTitulo.Select();
        }

        private void SetUpdateBookControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtTitulo.ReadOnly = false;

            dataGridCategorias.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelControls();
        }
    }
}
