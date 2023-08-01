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
            LbTituloTransacciones = new System.Windows.Forms.Label();
            dataGridTransactions = new System.Windows.Forms.DataGridView();
            btnGet = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            btnEliminar = new System.Windows.Forms.Button();
            btnPrestamo = new System.Windows.Forms.Button();
            radButtLector = new System.Windows.Forms.RadioButton();
            radButtLibro = new System.Windows.Forms.RadioButton();
            btnDevolucion = new System.Windows.Forms.Button();
            chkboxTransCompletas = new System.Windows.Forms.CheckBox();
            btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).BeginInit();
            SuspendLayout();
            // 
            // LbTituloTransacciones
            // 
            LbTituloTransacciones.AutoSize = true;
            LbTituloTransacciones.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LbTituloTransacciones.Location = new System.Drawing.Point(12, 9);
            LbTituloTransacciones.Name = "LbTituloTransacciones";
            LbTituloTransacciones.Size = new System.Drawing.Size(163, 42);
            LbTituloTransacciones.TabIndex = 37;
            LbTituloTransacciones.Text = "Prestamos";
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTransactions.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Location = new System.Drawing.Point(12, 84);
            dataGridTransactions.MultiSelect = false;
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.ReadOnly = true;
            dataGridTransactions.RowHeadersVisible = false;
            dataGridTransactions.RowTemplate.Height = 25;
            dataGridTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridTransactions.Size = new System.Drawing.Size(657, 354);
            dataGridTransactions.TabIndex = 4;
            // 
            // btnGet
            // 
            btnGet.BackColor = System.Drawing.Color.SeaShell;
            btnGet.BackgroundImage = Properties.Resources.reload_ui_2_svgrepo_com;
            btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnGet.FlatAppearance.BorderSize = 3;
            btnGet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGet.Location = new System.Drawing.Point(640, 55);
            btnGet.Name = "btnGet";
            btnGet.Size = new System.Drawing.Size(29, 23);
            btnGet.TabIndex = 43;
            btnGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(12, 54);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new System.Drawing.Size(345, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
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
            btnEliminar.Location = new System.Drawing.Point(675, 174);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(122, 39);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar ";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPrestamo
            // 
            btnPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnPrestamo.BackColor = System.Drawing.Color.SeaShell;
            btnPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPrestamo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnPrestamo.FlatAppearance.BorderSize = 3;
            btnPrestamo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPrestamo.Image = Properties.Resources.plus;
            btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrestamo.Location = new System.Drawing.Point(675, 84);
            btnPrestamo.Name = "btnPrestamo";
            btnPrestamo.Size = new System.Drawing.Size(122, 39);
            btnPrestamo.TabIndex = 1;
            btnPrestamo.Text = "Prestamo";
            btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnPrestamo.UseVisualStyleBackColor = false;
            btnPrestamo.Click += btnPrestamo_Click;
            // 
            // radButtLector
            // 
            radButtLector.AutoSize = true;
            radButtLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radButtLector.Location = new System.Drawing.Point(366, 56);
            radButtLector.Name = "radButtLector";
            radButtLector.Size = new System.Drawing.Size(64, 20);
            radButtLector.TabIndex = 46;
            radButtLector.TabStop = true;
            radButtLector.Text = "Lector";
            radButtLector.UseVisualStyleBackColor = true;
            radButtLector.CheckedChanged += radButtLector_CheckedChanged;
            // 
            // radButtLibro
            // 
            radButtLibro.AutoSize = true;
            radButtLibro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radButtLibro.Location = new System.Drawing.Point(436, 56);
            radButtLibro.Name = "radButtLibro";
            radButtLibro.Size = new System.Drawing.Size(57, 20);
            radButtLibro.TabIndex = 47;
            radButtLibro.TabStop = true;
            radButtLibro.Text = "Libro";
            radButtLibro.UseVisualStyleBackColor = true;
            radButtLibro.CheckedChanged += radButtLibro_CheckedChanged;
            // 
            // btnDevolucion
            // 
            btnDevolucion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDevolucion.BackColor = System.Drawing.Color.SeaShell;
            btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnDevolucion.FlatAppearance.BorderSize = 3;
            btnDevolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDevolucion.Image = Properties.Resources.izquierda;
            btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDevolucion.Location = new System.Drawing.Point(675, 129);
            btnDevolucion.Name = "btnDevolucion";
            btnDevolucion.Size = new System.Drawing.Size(122, 39);
            btnDevolucion.TabIndex = 2;
            btnDevolucion.Text = " Devolucion";
            btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDevolucion.UseVisualStyleBackColor = false;
            btnDevolucion.Click += btnDevolucion_Click;
            // 
            // chkboxTransCompletas
            // 
            chkboxTransCompletas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            chkboxTransCompletas.AutoSize = true;
            chkboxTransCompletas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkboxTransCompletas.Location = new System.Drawing.Point(675, 402);
            chkboxTransCompletas.Name = "chkboxTransCompletas";
            chkboxTransCompletas.Size = new System.Drawing.Size(95, 36);
            chkboxTransCompletas.TabIndex = 50;
            chkboxTransCompletas.Text = "Ocultar \r\nCompletos\r\n";
            chkboxTransCompletas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkboxTransCompletas.UseVisualStyleBackColor = true;
            chkboxTransCompletas.CheckedChanged += chkboxTransCompletas_CheckedChanged;
            // 
            // btnPrint
            // 
            btnPrint.BackgroundImage = Properties.Resources.printer_paper_icon_145946;
            btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnPrint.Location = new System.Drawing.Point(605, 55);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(29, 23);
            btnPrint.TabIndex = 51;
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(195, 164, 146);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(chkboxTransCompletas);
            Controls.Add(btnDevolucion);
            Controls.Add(radButtLibro);
            Controls.Add(radButtLector);
            Controls.Add(btnEliminar);
            Controls.Add(btnPrestamo);
            Controls.Add(btnGet);
            Controls.Add(txtBuscar);
            Controls.Add(dataGridTransactions);
            Controls.Add(LbTituloTransacciones);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "TransactionsForm";
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnPrint;
    }
}