
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopBiblioteca.Entities
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Editorial { get; set; }
        public string Author { get; set; }
        public int CategoryID { get; set; }
        public int Quantity { get; set; }

        public Category Category { get; set; }  
    }
}
