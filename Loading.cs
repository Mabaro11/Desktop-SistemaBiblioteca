using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopBiblioteca
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            //pbLoading.Location = new Point(this.Width/2 - pbLoading.Width/2, this.Height / 2 - pbLoading.Height / 2);
        }
    }
}
