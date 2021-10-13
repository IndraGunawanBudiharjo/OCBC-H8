using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan merk laptop: ");
            string newMerk = Console.ReadLine();
            Console.WriteLine("Masukkan ukuran ram laptop: ");
            int newRam = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan ukuran memory laptop: ");
            int newMemory = Int32.Parse(Console.ReadLine());

            // instansiasi objek
            Laptop laptop1 = new Laptop(newMerk, newRam, newMemory);

            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);
            
            // akses method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

        }
    }
}
