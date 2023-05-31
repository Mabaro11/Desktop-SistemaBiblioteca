namespace DesktopBiblioteca.Forms
{
    partial class NewTransactionForm
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
            this.btnCancelNewTransact = new System.Windows.Forms.Button();
            this.btnSaveNewTransact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.dataGridLibros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreLector = new System.Windows.Forms.TextBox();
            this.dataGridLectores = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTituloSeleccionado = new System.Windows.Forms.TextBox();
            this.lblLector = new System.Windows.Forms.Label();
            this.txtLectorSeleccionado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelNewTransact
            // 
            this.btnCancelNewTransact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelNewTransact.BackColor = System.Drawing.Color.SeaShell;
            this.btnCancelNewTransact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelNewTransact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelNewTransact.FlatAppearance.BorderSize = 3;
            this.btnCancelNewTransact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelNewTransact.Image = global::DesktopBiblioteca.Properties.Resources.close;
            this.btnCancelNewTransact.Location = new System.Drawing.Point(726, 373);
            this.btnCancelNewTransact.Name = "btnCancelNewTransact";
            this.btnCancelNewTransact.Size = new System.Drawing.Size(62, 39);
            this.btnCancelNewTransact.TabIndex = 3;
            this.btnCancelNewTransact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelNewTransact.UseVisualStyleBackColor = false;
            this.btnCancelNewTransact.Click += new System.EventHandler(this.btnCancelNewTransact_Click);
            // 
            // btnSaveNewTransact
            // 
            this.btnSaveNewTransact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveNewTransact.BackColor = System.Drawing.Color.SeaShell;
            this.btnSaveNewTransact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNewTransact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveNewTransact.FlatAppearance.BorderSize = 3;
            this.btnSaveNewTransact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNewTransact.Image = global::DesktopBiblioteca.Properties.Resources.guardar_el_archivo;
            this.btnSaveNewTransact.Location = new System.Drawing.Point(658, 373);
            this.btnSaveNewTransact.Name = "btnSaveNewTransact";
            this.btnSaveNewTransact.Size = new System.Drawing.Size(62, 39);
            this.btnSaveNewTransact.TabIndex = 2;
            this.btnSaveNewTransact.UseVisualStyleBackColor = false;
            this.btnSaveNewTransact.Click += new System.EventHandler(this.btnSaveNewTransact_ClickAsync);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Libro";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(164)))), ((int)(((byte)(146)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTituloLibro);
            this.panel1.Controls.Add(this.dataGridLibros);
            this.panel1.Location = new System.Drawing.Point(7, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 336);
            this.panel1.TabIndex = 54;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(3, 10);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.PlaceholderText = "Buscar...";
            this.txtTituloLibro.Size = new System.Drawing.Size(376, 23);
            this.txtTituloLibro.TabIndex = 0;
            this.txtTituloLibro.TextChanged += new System.EventHandler(this.txtTituloLibro_TextChanged);
            // 
            // dataGridLibros
            // 
            this.dataGridLibros.AllowUserToAddRows = false;
            this.dataGridLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLibros.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridLibros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridLibros.Location = new System.Drawing.Point(3, 39);
            this.dataGridLibros.MultiSelect = false;
            this.dataGridLibros.Name = "dataGridLibros";
            this.dataGridLibros.ReadOnly = true;
            this.dataGridLibros.RowHeadersVisible = false;
            this.dataGridLibros.RowTemplate.Height = 25;
            this.dataGridLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLibros.Size = new System.Drawing.Size(376, 292);
            this.dataGridLibros.TabIndex = 44;
            this.dataGridLibros.TabStop = false;
            this.dataGridLibros.SelectionChanged += new System.EventHandler(this.dataGridLibros_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(422, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Lector";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(164)))), ((int)(((byte)(146)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNombreLector);
            this.panel2.Controls.Add(this.dataGridLectores);
            this.panel2.Location = new System.Drawing.Point(404, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 336);
            this.panel2.TabIndex = 56;
            // 
            // txtNombreLector
            // 
            this.txtNombreLector.Location = new System.Drawing.Point(3, 10);
            this.txtNombreLector.Name = "txtNombreLector";
            this.txtNombreLector.PlaceholderText = "Buscar...";
            this.txtNombreLector.Size = new System.Drawing.Size(376, 23);
            this.txtNombreLector.TabIndex = 1;
            this.txtNombreLector.TextChanged += new System.EventHandler(this.txtNombreLector_TextChanged);
            // 
            // dataGridLectores
            // 
            this.dataGridLectores.AllowUserToAddRows = false;
            this.dataGridLectores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridLectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLectores.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridLectores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridLectores.Location = new System.Drawing.Point(3, 39);
            this.dataGridLectores.MultiSelect = false;
            this.dataGridLectores.Name = "dataGridLectores";
            this.dataGridLectores.ReadOnly = true;
            this.dataGridLectores.RowHeadersVisible = false;
            this.dataGridLectores.RowTemplate.Height = 25;
            this.dataGridLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLectores.Size = new System.Drawing.Size(376, 292);
            this.dataGridLectores.TabIndex = 45;
            this.dataGridLectores.TabStop = false;
            this.dataGridLectores.SelectionChanged += new System.EventHandler(this.dataGridLectores_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(7, 353);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 17);
            this.lblTitulo.TabIndex = 58;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtTituloSeleccionado
            // 
            this.txtTituloSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloSeleccionado.BackColor = System.Drawing.Color.SeaShell;
            this.txtTituloSeleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTituloSeleccionado.Location = new System.Drawing.Point(8, 373);
            this.txtTituloSeleccionado.Multiline = true;
            this.txtTituloSeleccionado.Name = "txtTituloSeleccionado";
            this.txtTituloSeleccionado.ReadOnly = true;
            this.txtTituloSeleccionado.Size = new System.Drawing.Size(384, 39);
            this.txtTituloSeleccionado.TabIndex = 59;
            this.txtTituloSeleccionado.TabStop = false;
            // 
            // lblLector
            // 
            this.lblLector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLector.AutoSize = true;
            this.lblLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLector.Location = new System.Drawing.Point(404, 353);
            this.lblLector.Name = "lblLector";
            this.lblLector.Size = new System.Drawing.Size(52, 17);
            this.lblLector.TabIndex = 60;
            this.lblLector.Text = "Lector:";
            // 
            // txtLectorSeleccionado
            // 
            this.txtLectorSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLectorSeleccionado.BackColor = System.Drawing.Color.SeaShell;
            this.txtLectorSeleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLectorSeleccionado.Location = new System.Drawing.Point(404, 373);
            this.txtLectorSeleccionado.Name = "txtLectorSeleccionado";
            this.txtLectorSeleccionado.ReadOnly = true;
            this.txtLectorSeleccionado.Size = new System.Drawing.Size(230, 23);
            this.txtLectorSeleccionado.TabIndex = 61;
            this.txtLectorSeleccionado.TabStop = false;
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(164)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.lblLector);
            this.Controls.Add(this.txtLectorSeleccionado);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTituloSeleccionado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelNewTransact);
            this.Controls.Add(this.btnSaveNewTransact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewTransactionForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Prestamo";
            this.Load += new System.EventHandler(this.NewTransactionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelNewTransact;
        private System.Windows.Forms.Button btnSaveNewTransact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTituloSeleccionado;
        private System.Windows.Forms.Label lblLector;
        private System.Windows.Forms.TextBox txtLectorSeleccionado;
        private System.Windows.Forms.DataGridView dataGridLibros;
        private System.Windows.Forms.DataGridView dataGridLectores;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtNombreLector;
    }
}