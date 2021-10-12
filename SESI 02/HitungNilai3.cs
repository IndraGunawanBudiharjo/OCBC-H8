using System;

    public class HitungNilai3
    {
        public static void Main(string[] args)
        {
            Console.Write("Jumlah nilai1: ");
            int nilai1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jumlah nilai2: ");
            int nilai2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Perbandingan: ");
            Console.WriteLine("Nilai1 > Nilai2: " + (nilai1 > nilai2));
            Console.WriteLine("Nilai1 >= Nilai2: " + (nilai1 >= nilai2));
            Console.WriteLine("Nilai1 < Nilai2: " + (nilai1 < nilai2));
            Console.WriteLine("Nilai1 <= Nilai2: " + (nilai1 <= nilai2));
            Console.WriteLine("Nilai1 == Nilai2: " + (nilai1 == nilai2));
            Console.WriteLine("Nilai1 != Nilai2: " + (nilai1 != nilai2));
   
        }
    }