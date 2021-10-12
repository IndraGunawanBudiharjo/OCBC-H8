using System;

    public class Hello
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello Indra");
            Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
            Console.WriteLine("Tahap 1 saya akan belajar C#");

            string namaCustomer = "foxi";
            double harga1 = 10.000, harga2 = 5.000, harga3 = 20.000;
            int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13;

            double totalHarga1 = harga1 * jumlah1;
            double totalHarga2 = harga2 * jumlah2;
            double totalHarga3 = harga3 * jumlah3;

            double totalHargaSemuaBarang = totalHarga1 + totalHarga2 + totalHarga3;
            int jumlahSemuaBarang = jumlah1 + jumlah2 + jumlah3;

            Console.WriteLine();
            Console.WriteLine("Nama Customer: " + namaCustomer);
            Console.WriteLine("Barang 1 berjumlah: " + jumlah1 + " dengan harga: " + harga1 + ", total harga yang harus dibayar: " + jumlah1 * harga1);
            Console.WriteLine("Barang 2 berjumlah: " + jumlah2 + " dengan harga: " + harga2 + ", total harga yang harus dibayar: " + jumlah2 * harga2);
            Console.WriteLine("Barang 3 berjumlah: " + jumlah3 + " dengan harga: " + harga3 + ", total harga yang harus dibayar: " + jumlah3 * harga3);
            Console.WriteLine();
            Console.WriteLine("Jumlah semua barang: " + jumlahSemuaBarang);
            Console.WriteLine("Total harga semua barang: " + totalHargaSemuaBarang);
            
        
        }
    }
 