using DesktopBiblioteca.ApiHelper;
using DesktopBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBiblioteca
{
    public partial class Form1 : Form
    {
        private String URI = "https://jsonplaceholder.typicode.com/posts";

        Loading loading;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            Show();
            //Creamos el listado de Posts a llenar
            List<Post> listado = new List<Post>();
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute<List<Post>>(URI, ApiHelper.methodHttp.GET, listado);
            Hide();

            //Poblamos el datagridview
            this.dataGridPosts.DataSource = oReply.Data;
            //Mostramos el statuscode devuelto, podemos añadirle lógica de validación
            MessageBox.Show(oReply.StatusCode);
        }


        private Task<Reply> Algo(List<Post>listado)
        {
            return Consumer.Execute<List<Post>>(URI, ApiHelper.methodHttp.GET, listado);
        }

        public void Show()
        {
            loading = new Loading();
            loading.Show();
        }
        public void Hide()
        {
            if(loading != null)
                loading.Close();
        }


        private async void btnPost_Click(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                userId = 1,
                title = "titulo del post",
                body = "Cuerpo del post"

            };

            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Post>(URI, ApiHelper.methodHttp.POST, post);

            MessageBox.Show(oReply.StatusCode);

        }
    }
}
