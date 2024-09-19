using System;
using System.Collections.Generic;

namespace quiz1
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> daftarConsumer = new List<Customer>
            {
                new Customer("Wili", 100000),
                new Customer("Surya", 100000)
            };

            Console.Write("Apakah Anda user atau admin? (costumer/admin): ");
            string pilihan = Console.ReadLine().ToLower();

            if (pilihan == "costumer")
            {
                Console.WriteLine("Pilih consumer:");
                for (int i = 0; i < daftarConsumer.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {daftarConsumer[i].Nama} (Saldo: {daftarConsumer[i].Emoney})");
                }

                Console.Write("Masukkan nama consumer: ");
                string namaConsumer = Console.ReadLine();

                // Cari customer berdasarkan nama
                int nomorConsumer = daftarConsumer.FindIndex(c => c.Nama.Equals(namaConsumer, StringComparison.OrdinalIgnoreCase));

                if (nomorConsumer != -1)
                {
                    Console.WriteLine($"Anda memilih {daftarConsumer[nomorConsumer].Nama} dengan saldo {daftarConsumer[nomorConsumer].Emoney}");
                }
                else
                {
                    Console.WriteLine("Nama consumer tidak ditemukan.");
                }
            }
            else if (pilihan == "admin")
            {
                Admin admin = new Admin("Admin");

                Console.WriteLine("Daftar consumer:");
                for (int i = 0; i < daftarConsumer.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {daftarConsumer[i].Nama} (Saldo: {daftarConsumer[i].Emoney})");
                }

                Console.Write("Pilih nomor consumer untuk menambah saldo: ");
                int nomorConsumer = int.Parse(Console.ReadLine()) - 1;

                if (nomorConsumer >= 0 && nomorConsumer < daftarConsumer.Count)
                {
                    Console.Write("Masukkan jumlah saldo yang akan ditambahkan: ");
                    int jumlahSaldo = int.Parse(Console.ReadLine());

                    admin.TambahSaldo(daftarConsumer[nomorConsumer], jumlahSaldo);
                }
                else
                {
                    Console.WriteLine("Nomor consumer tidak valid.");
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid.");
            }
        }
    }
}
