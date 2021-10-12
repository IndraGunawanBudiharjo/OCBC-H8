using System;

    public class HitungNilai
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===Menghitung Nilai===");
            Console.Write("Masukkan nilai pertama: ");
            int nilai1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai kedua: ");
            int nilai2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai ketiga: ");
            int nilai3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total nilai: " + (nilai1 + nilai2 + nilai3));
            Console.WriteLine("Rerata nilai: " + ((nilai1 + nilai2 + nilai3) / 3));
        }
    }