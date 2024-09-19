
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    internal class Admin : User
    {
        public Admin(string nama)
        {
            Nama = nama;
            Role = "Admin";
        }

        public void TambahSaldo(Customer consumer, int jumlah)
        {
            consumer.Emoney += jumlah;
            Console.WriteLine($"Saldo {consumer.Nama} ditambah {jumlah}. Saldo sekarang: {consumer.Emoney}");
        }
    }
}
