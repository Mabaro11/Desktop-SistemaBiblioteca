using DesktopBiblioteca.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopBiblioteca
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void OpenChildForms(object ChildForm)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form chForm = ChildForm as Form;
            chForm.TopLevel = false;
            chForm.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(chForm);
            this.panelContenedor.Tag = chForm;
            chForm.Show();
            
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReadersForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                OpenChildForms(frm);
                return;
            }
            //sino existe la instancia se crea una nueva
            OpenChildForms(new ReadersForm());

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is BooksForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                OpenChildForms(frm);
                return;
            }
            //sino existe la instancia se crea una nueva
            OpenChildForms(new BooksForm());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TransactionsForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                OpenChildForms(frm);
                return;
            }
            //sino existe la instancia se crea una nueva
            OpenChildForms(new TransactionsForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReadersForm);
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                OpenChildForms(frm);
                return;
            }
            //sino existe la instancia se crea una nueva
            OpenChildForms(new ReadersForm());
        }
    }
}
