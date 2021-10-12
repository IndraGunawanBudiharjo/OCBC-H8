using System;

    public class StringExample
    {
        public static void Main(string[] args)
        {
            Console.Write("Masukkan Nama: ");
            string name = Console.ReadLine();
            Console.Write("Masukkan Alamat: ");
            string address = Console.ReadLine();
            Console.Write("Masukkan Umur: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima Kasih!");
            Console.WriteLine("Data Berikut");
            Console.WriteLine($"Nama: {name}");
            Console.WriteLine($"Alamat: {address}");
            Console.WriteLine($"Umur: {age}");
            Console.WriteLine("SUDAH DISIMPAN!");
        }
    }