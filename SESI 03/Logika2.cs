using System;

    public class Logika2 
    {
        public static void Main(string[] args) 
        {
            Console.Write("Masukkan nama: ");
            string name = Console.ReadLine();

            Console.Write("Masukkan nilaimu: ");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if(nilai < 60) {
                Console.WriteLine($"Belajar Lebih Giat {name}, Nilai Kamu C");
            }
            else if(nilai < 80) {
                Console.WriteLine($"Nilai Kamu B, Tingkatkan Lagi {name}");
            }
            else {
                Console.WriteLine($"Mantap {name}!, Nilai Kamu A");
            }
        }
    }