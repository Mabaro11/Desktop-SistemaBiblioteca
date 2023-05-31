namespace DesktopBiblioteca.Forms
{
    partial class TransactionsForm
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
            this.LbTituloTransacciones = new System.Windows.Forms.Label();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.radButtLector = new System.Windows.Forms.RadioButton();
            this.radButtLibro = new System.Windows.Forms.RadioButton();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.chkboxTransCompletas = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTituloTransacciones
            // 
            this.LbTituloTransacciones.AutoSize = true;
            this.LbTituloTransacciones.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbTituloTransacciones.Location = new System.Drawing.Point(12, 9);
            this.LbTituloTransacciones.Name = "LbTituloTransacciones";
            this.LbTituloTransacciones.Size = new System.Drawing.Size(163, 42);
            this.LbTituloTransacciones.TabIndex = 37;
            this.LbTituloTransacciones.Text = "Prestamos";
            // 
            // dataGridTransactions
            // 
            this.dataGridTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransactions.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactions.Location = new System.Drawing.Point(12, 84);
            this.dataGridTransactions.MultiSelect = false;
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.ReadOnly = true;
            this.dataGridTransactions.RowHeadersVisible = false;
            this.dataGridTransactions.RowTemplate.Height = 25;
            this.dataGridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTransactions.Size = new System.Drawing.Size(657, 354);
            this.dataGridTransactions.TabIndex = 4;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.SeaShell;
            this.btnGet.BackgroundImage = global::DesktopBiblioteca.Properties.Resources.reload_ui_2_svgrepo_com;
            this.btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGet.FlatAppearance.BorderSize = 3;
            this.btnGet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGet.Location = new System.Drawing.Point(640, 55);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(29, 23);
            this.btnGet.TabIndex = 43;
            this.btnGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.Size = new System.Drawing.Size(345, 23);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.SeaShell;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Image = global::DesktopBiblioteca.Properties.Resources.eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(675, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 39);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrestamo.BackColor = System.Drawing.Color.SeaShell;
            this.btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrestamo.FlatAppearance.BorderSize = 3;
            this.btnPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrestamo.Image = global::DesktopBiblioteca.Properties.Resources.plus;
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(675, 84);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(122, 39);
            this.btnPrestamo.TabIndex = 1;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // radButtLector
            // 
            this.radButtLector.AutoSize = true;
            this.radButtLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radButtLector.Location = new System.Drawing.Point(366, 56);
            this.radButtLector.Name = "radButtLector";
            this.radButtLector.Size = new System.Drawing.Size(64, 20);
            this.radButtLector.TabIndex = 46;
            this.radButtLector.TabStop = true;
            this.radButtLector.Text = "Lector";
            this.radButtLector.UseVisualStyleBackColor = true;
            this.radButtLector.CheckedChanged += new System.EventHandler(this.radButtLector_CheckedChanged);
            // 
            // radButtLibro
            // 
            this.radButtLibro.AutoSize = true;
            this.radButtLibro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radButtLibro.Location = new System.Drawing.Point(436, 56);
            this.radButtLibro.Name = "radButtLibro";
            this.radButtLibro.Size = new System.Drawing.Size(57, 20);
            this.radButtLibro.TabIndex = 47;
            this.radButtLibro.TabStop = true;
            this.radButtLibro.Text = "Libro";
            this.radButtLibro.UseVisualStyleBackColor = true;
            this.radButtLibro.CheckedChanged += new System.EventHandler(this.radButtLibro_CheckedChanged);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDevolucion.BackColor = System.Drawing.Color.SeaShell;
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDevolucion.FlatAppearance.BorderSize = 3;
            this.btnDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDevolucion.Image = global::DesktopBiblioteca.Properties.Resources.izquierda;
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.Location = new System.Drawing.Point(675, 129);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(122, 39);
            this.btnDevolucion.TabIndex = 2;
            this.btnDevolucion.Text = " Devolucion";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // chkboxTransCompletas
            // 
            this.chkboxTransCompletas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkboxTransCompletas.AutoSize = true;
            this.chkboxTransCompletas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkboxTransCompletas.Location = new System.Drawing.Point(675, 402);
            this.chkboxTransCompletas.Name = "chkboxTransCompletas";
            this.chkboxTransCompletas.Size = new System.Drawing.Size(95, 36);
            this.chkboxTransCompletas.TabIndex = 50;
            this.chkboxTransCompletas.Text = "Ocultar \r\nCompletos\r\n";
            this.chkboxTransCompletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkboxTransCompletas.UseVisualStyleBackColor = true;
            this.chkboxTransCompletas.CheckedChanged += new System.EventHandler(this.chkboxTransCompletas_CheckedChanged);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(164)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkboxTransCompletas);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.radButtLibro);
            this.Controls.Add(this.radButtLector);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataGridTransactions);
            this.Controls.Add(this.LbTituloTransacciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTituloTransacciones;
        private System.Windows.Forms.DataGridView dataGridTransactions;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.RadioButton radButtLector;
        private System.Windows.Forms.RadioButton radButtLibro;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.CheckBox chkboxTransCompletas;
    }
}