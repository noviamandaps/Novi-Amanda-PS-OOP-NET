using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    internal class Customer : User
    {
        public Customer(string nama, int emoney)
        {
            Nama = nama;
            Emoney = emoney;
            Role = "Consumer";
        }
    }
}
