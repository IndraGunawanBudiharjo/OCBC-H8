using System;

namespace pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur pswtTempur = new PesawatTempur();

            pesawat.Nama ="Heli";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = 3;
            pswtTempur.Nama = "AZ500TPU";
            pswtTempur.JumlahRoda = 5;
            pswtTempur.Ketinggian = "200 kaki";
            pswtTempur.JumlahPenumpang = 20;

            pesawat.Terbang();
            pswtTempur.Terbang();


        }
    }
}
