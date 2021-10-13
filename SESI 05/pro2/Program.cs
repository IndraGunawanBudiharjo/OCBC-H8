using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Masukkan nama pesawat: ");
            string newNama = Console.ReadLine();

            Console.Write("Masukkan ketinggian: ");
            string newKetinggian = Console.ReadLine();
            
            Pesawat pesawat1 = new Pesawat(newNama, newKetinggian);

            // akses getter dan setter
            // pesawat1.Ketinggian = "1000 kaki";
            // Console.WriteLine("Ketinggian saat ini: {0}", pesawat1.Ketinggian);

            pesawat1.Terbang();
            pesawat1.SudahTerbang();

            
        }
    }
}
