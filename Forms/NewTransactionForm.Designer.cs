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
            btnCancelNewTransact = new System.Windows.Forms.Button();
            btnSaveNewTransact = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            txtTituloLibro = new System.Windows.Forms.TextBox();
            dataGridLibros = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            txtNombreLector = new System.Windows.Forms.TextBox();
            dataGridLectores = new System.Windows.Forms.DataGridView();
            lblTitulo = new System.Windows.Forms.Label();
            txtTituloSeleccionado = new System.Windows.Forms.TextBox();
            lblLector = new System.Windows.Forms.Label();
            txtLectorSeleccionado = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLectores).BeginInit();
            SuspendLayout();
            // 
            // btnCancelNewTransact
            // 
            btnCancelNewTransact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnCancelNewTransact.BackColor = System.Drawing.Color.SeaShell;
            btnCancelNewTransact.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancelNewTransact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnCancelNewTransact.FlatAppearance.BorderSize = 3;
            btnCancelNewTransact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelNewTransact.Image = Properties.Resources.close;
            btnCancelNewTransact.Location = new System.Drawing.Point(726, 386);
            btnCancelNewTransact.Name = "btnCancelNewTransact";
            btnCancelNewTransact.Size = new System.Drawing.Size(62, 39);
            btnCancelNewTransact.TabIndex = 3;
            btnCancelNewTransact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelNewTransact.UseVisualStyleBackColor = false;
            btnCancelNewTransact.Click += btnCancelNewTransact_Click;
            // 
            // btnSaveNewTransact
            // 
            btnSaveNewTransact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnSaveNewTransact.BackColor = System.Drawing.Color.SeaShell;
            btnSaveNewTransact.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveNewTransact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btnSaveNewTransact.FlatAppearance.BorderSize = 3;
            btnSaveNewTransact.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveNewTransact.Image = Properties.Resources.guardar_el_archivo;
            btnSaveNewTransact.Location = new System.Drawing.Point(658, 386);
            btnSaveNewTransact.Name = "btnSaveNewTransact";
            btnSaveNewTransact.Size = new System.Drawing.Size(62, 39);
            btnSaveNewTransact.TabIndex = 2;
            btnSaveNewTransact.UseVisualStyleBackColor = false;
            btnSaveNewTransact.Click += btnSaveNewTransact_ClickAsync;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(25, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 17);
            label1.TabIndex = 55;
            label1.Text = "Libro";
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(195, 164, 146);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(txtTituloLibro);
            panel1.Controls.Add(dataGridLibros);
            panel1.Location = new System.Drawing.Point(7, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(384, 336);
            panel1.TabIndex = 54;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new System.Drawing.Point(3, 10);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.PlaceholderText = "Buscar...";
            txtTituloLibro.Size = new System.Drawing.Size(376, 23);
            txtTituloLibro.TabIndex = 0;
            txtTituloLibro.TextChanged += txtTituloLibro_TextChanged;
            // 
            // dataGridLibros
            // 
            dataGridLibros.AllowUserToAddRows = false;
            dataGridLibros.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLibros.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridLibros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridLibros.Location = new System.Drawing.Point(3, 39);
            dataGridLibros.MultiSelect = false;
            dataGridLibros.Name = "dataGridLibros";
            dataGridLibros.ReadOnly = true;
            dataGridLibros.RowHeadersVisible = false;
            dataGridLibros.RowTemplate.Height = 25;
            dataGridLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridLibros.Size = new System.Drawing.Size(376, 292);
            dataGridLibros.TabIndex = 44;
            dataGridLibros.TabStop = false;
            dataGridLibros.SelectionChanged += dataGridLibros_SelectionChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(422, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 17);
            label2.TabIndex = 57;
            label2.Text = "Lector";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.Color.FromArgb(195, 164, 146);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(txtNombreLector);
            panel2.Controls.Add(dataGridLectores);
            panel2.Location = new System.Drawing.Point(404, 15);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(384, 336);
            panel2.TabIndex = 56;
            // 
            // txtNombreLector
            // 
            txtNombreLector.Location = new System.Drawing.Point(3, 10);
            txtNombreLector.Name = "txtNombreLector";
            txtNombreLector.PlaceholderText = "Buscar...";
            txtNombreLector.Size = new System.Drawing.Size(376, 23);
            txtNombreLector.TabIndex = 1;
            txtNombreLector.TextChanged += txtNombreLector_TextChanged;
            // 
            // dataGridLectores
            // 
            dataGridLectores.AllowUserToAddRows = false;
            dataGridLectores.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridLectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLectores.BackgroundColor = System.Drawing.Color.SeaShell;
            dataGridLectores.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridLectores.Location = new System.Drawing.Point(3, 39);
            dataGridLectores.MultiSelect = false;
            dataGridLectores.Name = "dataGridLectores";
            dataGridLectores.ReadOnly = true;
            dataGridLectores.RowHeadersVisible = false;
            dataGridLectores.RowTemplate.Height = 25;
            dataGridLectores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridLectores.Size = new System.Drawing.Size(376, 292);
            dataGridLectores.TabIndex = 45;
            dataGridLectores.TabStop = false;
            dataGridLectores.SelectionChanged += dataGridLectores_SelectionChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(7, 353);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(45, 17);
            lblTitulo.TabIndex = 58;
            lblTitulo.Text = "Titulo:";
            // 
            // txtTituloSeleccionado
            // 
            txtTituloSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtTituloSeleccionado.BackColor = System.Drawing.Color.SeaShell;
            txtTituloSeleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTituloSeleccionado.Location = new System.Drawing.Point(8, 373);
            txtTituloSeleccionado.Multiline = true;
            txtTituloSeleccionado.Name = "txtTituloSeleccionado";
            txtTituloSeleccionado.ReadOnly = true;
            txtTituloSeleccionado.Size = new System.Drawing.Size(384, 44);
            txtTituloSeleccionado.TabIndex = 59;
            txtTituloSeleccionado.TabStop = false;
            // 
            // lblLector
            // 
            lblLector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLector.AutoSize = true;
            lblLector.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLector.Location = new System.Drawing.Point(404, 353);
            lblLector.Name = "lblLector";
            lblLector.Size = new System.Drawing.Size(52, 17);
            lblLector.TabIndex = 60;
            lblLector.Text = "Lector:";
            // 
            // txtLectorSeleccionado
            // 
            txtLectorSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLectorSeleccionado.BackColor = System.Drawing.Color.SeaShell;
            txtLectorSeleccionado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLectorSeleccionado.Location = new System.Drawing.Point(404, 373);
            txtLectorSeleccionado.Name = "txtLectorSeleccionado";
            txtLectorSeleccionado.ReadOnly = true;
            txtLectorSeleccionado.Size = new System.Drawing.Size(230, 23);
            txtLectorSeleccionado.TabIndex = 61;
            txtLectorSeleccionado.TabStop = false;
            // 
            // NewTransactionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(195, 164, 146);
            ClientSize = new System.Drawing.Size(800, 429);
            Controls.Add(lblLector);
            Controls.Add(txtLectorSeleccionado);
            Controls.Add(lblTitulo);
            Controls.Add(txtTituloSeleccionado);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnCancelNewTransact);
            Controls.Add(btnSaveNewTransact);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "NewTransactionForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Nuevo Prestamo";
            Load += NewTransactionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLibros).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLectores).EndInit();
            ResumeLayout(false);
            PerformLayout();
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