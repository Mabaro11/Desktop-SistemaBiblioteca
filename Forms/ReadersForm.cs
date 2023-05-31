using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
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
    public partial class ReadersForm : Form
    {
        private String URI = "http://localhost:5000/api" + "/reader";

        BindingSource readersList = new BindingSource();

        BusyIndicator busyIndicator = new BusyIndicator();

        int idReaderModificado;
        public ReadersForm()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            GetReaders();
        }


        private async void GetReaders()
        {
            busyIndicator.Show(this.dataGridReaders);
            //Creamos el listado de Readers a llenar
            DataTable listado = new DataTable();
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute<DataTable>(URI, ApiHelper.methodHttp.GET, listado);
            busyIndicator.Hide();

            if (oReply.StatusCode != "OK")
            {
                if (MessageBox.Show(oReply.StatusCode, null, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            readersList.DataSource = oReply.Data;

            if (oReply.Data != null)
            {
                //Oculto Filas que no deseo.
                dataGridReaders.Columns["phone"].Visible = false; // Telefono
                dataGridReaders.Columns["address"].Visible = false; // Direccion
                dataGridReaders.Columns["email"].Visible = false; // Email 
                //Cambio el nombre a las que quedan
                dataGridReaders.Columns["name"].HeaderText = "Nombre";
                dataGridReaders.Columns["dni"].HeaderText = "DNI";
            }

        }

        private void dataGridReaders_SelectionChanged(object sender, EventArgs e)
        {
            if(readersList.Count > 0)
            {
                //Con este metodo del datagridview logro que se carguen en los los siguientes txt los valores seleccionados.
                txtNombre.Text = Convert.ToString(dataGridReaders.CurrentRow.Cells[1].Value);
                txtDNI.Text = Convert.ToString(dataGridReaders.CurrentRow.Cells[5].Value);
                txtTelefono.Text = Convert.ToString(dataGridReaders.CurrentRow.Cells[4].Value);
                txtDireccion.Text = Convert.ToString(dataGridReaders.CurrentRow.Cells[2].Value);
                txtEmail.Text = Convert.ToString(dataGridReaders.CurrentRow.Cells[3].Value);
            }
            else
            {
                CancelControls();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.idReaderModificado = 0;
            SetNewReaderControls();
            txtNombre.Select();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.idReaderModificado = Convert.ToInt32(dataGridReaders.CurrentRow.Cells[0].Value);
            SetUpdateReaderControls();
            txtNombre.Select();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelControls();

        }

        private void SetNewReaderControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtNombre.Clear();
            txtNombre.ReadOnly = false;

            txtTelefono.Clear();
            txtTelefono.ReadOnly = false;

            txtEmail.Clear();
            txtEmail.ReadOnly = false;

            txtDireccion.Clear();
            txtDireccion.ReadOnly = false;

            txtDNI.Clear();
            txtDNI.ReadOnly = false;

            dataGridReaders.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void SetUpdateReaderControls()
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;

            txtNombre.ReadOnly = false;
            txtTelefono.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtDNI.ReadOnly = false;

            dataGridReaders.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void CancelControls()
        {
            btnCancel.Visible = false;
            btnSave.Visible = false;

            txtNombre.Clear();
            txtNombre.ReadOnly = true;

            txtTelefono.Clear();
            txtTelefono.ReadOnly = true;

            txtEmail.Clear();
            txtEmail.ReadOnly = true;

            txtDireccion.Clear();
            txtDireccion.ReadOnly = true;

            txtDNI.Clear();
            txtDNI.ReadOnly = true;

            dataGridReaders.Enabled = true;
            //if(readersList.Count > 0) dataGridReaders.Rows[1].Selected = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //creamos un objeto del tipo reader
            Reader reader = new Reader();
            Reply oReply = new Reply();

            //Validamos y tomamos los valores de la pantalla para asignarselos a el objeto reader.
            if (txtDireccion.TextLength > 0 &&
                txtTelefono.TextLength > 0 &&
                txtNombre.TextLength > 0 &&
                txtDNI.TextLength > 0 &&
                txtEmail.TextLength > 0)
            {
                reader.name = txtNombre.Text;
                reader.dni = txtDNI.Text;
                reader.phone = txtTelefono.Text;
                reader.address = txtDireccion.Text;
                reader.email = txtEmail.Text;

                if (this.idReaderModificado == 0)
                {
                    //agregamos el reader a la tabla readers
                    //readersList.Add(reader);
                    oReply = await Consumer.Execute<Reader>(URI, ApiHelper.methodHttp.POST, reader);

                    MessageBox.Show(oReply.StatusCode);
                }
                else
                {
                    reader.id = this.idReaderModificado;
                    oReply = await Consumer.Execute<Reader>(URI + $"/{reader.id}", ApiHelper.methodHttp.PUT, reader);

                    MessageBox.Show(oReply.StatusCode);

                }
                CancelControls();
                GetReaders();
            }
            else
            {
                MessageBox.Show("Deben ingresarse todos los datos del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            Reply oReply = new Reply();
            var readerId = Convert.ToInt32(dataGridReaders.CurrentRow.Cells[0].Value);

            oReply = await Consumer.Execute<Reader>(URI + $"/{readerId}", ApiHelper.methodHttp.DELETE, reader);

            MessageBox.Show(oReply.StatusCode);
            GetReaders();

        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {
            GetReaders();

            this.dataGridReaders.DataSource = readersList;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            readersList.Filter = string.Format("name LIKE '%{0}%'", txtBuscar.Text);
            dataGridReaders.AllowUserToAddRows = false;
        }
    
    }
}
