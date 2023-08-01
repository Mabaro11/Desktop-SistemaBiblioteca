namespace DesktopBiblioteca
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MenuVertical = new System.Windows.Forms.Panel();
            btnTransactions = new System.Windows.Forms.Button();
            btnBooks = new System.Windows.Forms.Button();
            btnReaders = new System.Windows.Forms.Button();
            panelContenedor = new System.Windows.Forms.Panel();
            MenuVertical.SuspendLayout();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = System.Drawing.Color.FromArgb(31, 33, 32);
            MenuVertical.Controls.Add(btnTransactions);
            MenuVertical.Controls.Add(btnBooks);
            MenuVertical.Controls.Add(btnReaders);
            MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            MenuVertical.Location = new System.Drawing.Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new System.Drawing.Size(189, 508);
            MenuVertical.TabIndex = 1;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = System.Drawing.Color.DimGray;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTransactions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTransactions.ForeColor = System.Drawing.SystemColors.Menu;
            btnTransactions.Location = new System.Drawing.Point(-3, 224);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new System.Drawing.Size(192, 39);
            btnTransactions.TabIndex = 4;
            btnTransactions.TabStop = false;
            btnTransactions.Text = "Prestamos";
            btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = System.Drawing.Color.DimGray;
            btnBooks.FlatAppearance.BorderSize = 0;
            btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBooks.ForeColor = System.Drawing.SystemColors.Menu;
            btnBooks.Location = new System.Drawing.Point(0, 184);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new System.Drawing.Size(192, 39);
            btnBooks.TabIndex = 3;
            btnBooks.TabStop = false;
            btnBooks.Text = "Libros";
            btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // btnReaders
            // 
            btnReaders.BackColor = System.Drawing.Color.DimGray;
            btnReaders.FlatAppearance.BorderSize = 0;
            btnReaders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(0, 80, 200);
            btnReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReaders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReaders.ForeColor = System.Drawing.SystemColors.Menu;
            btnReaders.Location = new System.Drawing.Point(0, 144);
            btnReaders.Name = "btnReaders";
            btnReaders.Size = new System.Drawing.Size(189, 39);
            btnReaders.TabIndex = 2;
            btnReaders.TabStop = false;
            btnReaders.Text = "Lectores";
            btnReaders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReaders.UseVisualStyleBackColor = false;
            btnReaders.Click += btnReaders_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = System.Drawing.Color.Lavender;
            panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContenedor.Location = new System.Drawing.Point(189, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new System.Drawing.Size(816, 508);
            panelContenedor.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1005, 508);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            MenuVertical.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btnReaders;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnBooks;
    }
}