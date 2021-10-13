using System;

namespace pro6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Menu tugas sesi 5");
                Console.WriteLine("------------------");
                Console.WriteLine("1. Pesawat Tempur");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. About me");
                Console.WriteLine("5. Exit");
                Console.Write("Silakan pilih nomor: ");
                string pilih = Console.ReadLine();
                Console.WriteLine();
                
                if(pilih == "5") {
                    break;
                }

                if(pilih == "1") {
                    PesawatTempur pswtTempur = new PesawatTempur("AZ500TPU", "2000 kaki", 20, 5);
                    pswtTempur.Terbang();
                    Console.WriteLine();
                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back.ToLower() == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(pilih == "2") {
                    Console.Write("Masukkan Nama: ");
                    string nama = Console.ReadLine();
                    Console.Write("Masukkan No Telp: ");
                    int noTelp = Int32.Parse(Console.ReadLine());

                    Overload data = new Overload();
                    data.print(nama);
                    data.print(noTelp);
                    Console.WriteLine();
                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back.ToLower() == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(pilih == "3") {
                    Console.Write("Masukkan Angka Pertama: ");
                    int angka1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    int angka2 = Int32.Parse(Console.ReadLine());

                    Bilangan overiding = new Bilangan();
                    overiding.bilangan(angka1, angka2);
                    overiding.penjumlahanperkaliandll();
                    overiding = new Overide();
                    overiding.bilangan(angka1, angka2);
                    overiding.penjumlahanperkaliandll();
                    Console.WriteLine();
                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back.ToLower() == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(pilih == "4") {
                    Console.WriteLine("Halo semua, nama saya Indra");
                    Console.WriteLine("Saya sebelumnya belum pernah belajar C#");
                    Console.WriteLine("Setelah mengikuti kelas ini, saya tertarik dengan C#");
                    Console.WriteLine("Saya tidak sabar untuk belajar membuat API dengan .NET");
                    Console.WriteLine();
                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back.ToLower() == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(pilih != "1" && pilih != "2" && pilih != "3" && pilih != "4") {
                    Console.WriteLine("Silakan pilih nomor kembali");
                    Console.WriteLine();
                    continue;
                    
                }

            }
            
        }
    }
}
