using DesktopBiblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace DesktopBiblioteca.Interfaces
{
    internal interface ITransaction
    {
        void setNewTransaction(Transaction transaction);
    }
}
