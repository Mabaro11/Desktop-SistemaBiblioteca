using DesktopBiblioteca.ApiHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopBiblioteca.Entities
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
        public int ReaderID { get; set; }
        public virtual Reader Reader { get; set; }
        public int status { get; set; }

        public static implicit operator Transaction(Reply v)
        {
            throw new NotImplementedException();
        }
    }
}
