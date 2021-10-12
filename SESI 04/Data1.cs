using System;

    public class Data1 
    {
        public static void Main(string[] args)
        {
            // int[] angka = new int[5];
            string[] nama = new string[] {"Joni", "Meri", "David"};
            object[] objek = {20.33, "Lorem ipsum", DateTime.Now, true, 'D'};
            
            Console.WriteLine(nama[1]);
            Console.WriteLine(objek[0]);
        }
    }