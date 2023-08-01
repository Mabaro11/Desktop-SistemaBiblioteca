namespace DesktopBiblioteca.Forms
{
    partial class ReadersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscar = new System.Windows.Forms.TextBox();
            dataGridReaders = new System.Windows.Forms.DataGridView();
            txtDireccion = new System.Windows.Forms.TextBox();
            lblDireccion = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblTelefono = new System.Windows.Forms.Label();
            txtDNI = new System.Windows.Forms.TextBox();
            lblDNI = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            LbTituloClientes = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            btnGetReaders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridReaders).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(12, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new System.Drawing.Size(356, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dataGridReaders
            // 
            dataGridReaders.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReaders.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReaders.Location = new System.Drawing.Point(12, 41);
            dataGridReaders.MultiSelect = false;
            dataGridReaders.Name = "dataGridReaders";
            dataGridReaders.ReadOnly = true;
            dataGridReaders.RowHeadersVisible = false;
            dataGridReaders.RowTemplate.Height = 25;
            dataGridReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridReaders.Size = new System.Drawing.Size(391, 416);
            dataGridReaders.TabIndex = 1;
            dataGridReaders.TabStop = false;
            dataGridReaders.SelectionChanged += dataGridReaders_SelectionChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDireccion.BackColor = System.Drawing.Color.SeaShell;
            txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDireccion.Location = new System.Drawing.Point(117, 118);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new System.Drawing.Size(207, 23);
            txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDireccion.Location = new System.Drawing.Point(25, 121);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(73, 17);
            lblDireccion.TabIndex = 32;
            lblDireccion.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTelefono.BackColor = System.Drawing.Color.SeaShell;
            txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTelefono.Location = new System.Drawing.Point(117, 60);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new System.Drawing.Size(207, 23);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTelefono.Location = new System.Drawing.Point(32, 63);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(66, 17);
            lblTelefono.TabIndex = 30;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDNI
            // 
            txtDNI.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDNI.BackColor = System.Drawing.Color.SeaShell;
            txtDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDNI.Location = new System.Drawing.Point(117, 147);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new System.Drawing.Size(207, 23);
            txtDNI.TabIndex = 8;
            // 
            // lblDNI
            // 
            lblDNI.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDNI.AutoSize = true;
            lblDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDNI.Location = new System.Drawing.Point(63, 150);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new System.Drawing.Size(35, 17);
            lblDNI.TabIndex = 28;
            lblDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNombre.BackColor = System.Drawing.Color.SeaShell;
            txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNombre.Location = new System.Drawing.Point(117, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new System.Drawing.Size(207, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(33, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(65, 17);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre:";
            // 
            // btnModificar
            // 
            btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnModificar.BackColor = System.Drawing.Color.SeaShell;
            btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnModificar.FlatAppearance.BorderSize = 3;
            btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnModificar.Image = Properties.Resources.pencil;
            btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnModificar.Location = new System.Drawing.Point(548, 418);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(112, 39);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar ";
            btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnEliminar.BackColor = System.Drawing.Color.SeaShell;
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEliminar.Image = Properties.Resources.eliminar;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEliminar.Location = new System.Drawing.Point(676, 418);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(112, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEmail.BackColor = System.Drawing.Color.SeaShell;
            txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(117, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new System.Drawing.Size(207, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(51, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(47, 17);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email:";
            // 
            // LbTituloClientes
            // 
            LbTituloClientes.AutoSize = true;
            LbTituloClientes.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LbTituloClientes.Location = new System.Drawing.Point(421, 12);
            LbTituloClientes.Name = "LbTituloClientes";
            LbTituloClientes.Size = new System.Drawing.Size(135, 42);
            LbTituloClientes.TabIndex = 36;
            LbTituloClientes.Text = "Lectores";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.LightSlateGray;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(txtDNI);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(txtTelefono);
            panel1.Location = new System.Drawing.Point(421, 96);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(367, 198);
            panel1.TabIndex = 37;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(439, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(154, 17);
            label1.TabIndex = 38;
            label1.Text = "Informacion del Lector";
            // 
            // btnSave
            // 
            btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSave.BackColor = System.Drawing.Color.SeaShell;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.Image = Properties.Resources.guardar_el_archivo;
            btnSave.Location = new System.Drawing.Point(643, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(62, 39);
            btnSave.TabIndex = 9;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCancel.BackColor = System.Drawing.Color.SeaShell;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCancel.FlatAppearance.BorderSize = 3;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = Properties.Resources.close;
            btnCancel.Location = new System.Drawing.Point(724, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(62, 39);
            btnCancel.TabIndex = 10;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnNuevo.BackColor = System.Drawing.Color.SeaShell;
            btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnNuevo.FlatAppearance.BorderSize = 3;
            btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNuevo.Image = Properties.Resources.plus;
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNuevo.Location = new System.Drawing.Point(421, 418);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(112, 39);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo ";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGetReaders
            // 
            btnGetReaders.BackColor = System.Drawing.Color.SeaShell;
            btnGetReaders.BackgroundImage = Properties.Resources.reload_ui_2_svgrepo_com;
            btnGetReaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGetReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGetReaders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnGetReaders.FlatAppearance.BorderSize = 3;
            btnGetReaders.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGetReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGetReaders.Location = new System.Drawing.Point(374, 12);
            btnGetReaders.Name = "btnGetReaders";
            btnGetReaders.Size = new System.Drawing.Size(29, 23);
            btnGetReaders.TabIndex = 41;
            btnGetReaders.TabStop = false;
            btnGetReaders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGetReaders.UseVisualStyleBackColor = false;
            btnGetReaders.Click += btnGetReaders_Click;
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightSlateGray;
            ClientSize = new System.Drawing.Size(800, 469);
            Controls.Add(btnGetReaders);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(LbTituloClientes);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridReaders);
            Controls.Add(txtBuscar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ReadersForm";
            Text = "ReadersForm";
            Load += ReadersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridReaders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridReaders;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label LbTituloClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGetReaders;
    }
}