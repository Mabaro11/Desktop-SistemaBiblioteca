using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopBiblioteca.Entities
{
    public class Reader
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string dni { get; set; }

        public bool lower { get; set; }
    }
}
