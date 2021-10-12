using System;

    public class Logika8
    {
        public static void Main(string[] args)
        {
            Console.Write("Entry a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entry an end number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose operator:");
            string op = Console.ReadLine();

            int i = 0;

            if(op == "+"){
                do {
                    Console.WriteLine($"nilai i = {i} dan hasilnya {i+num}");
                    i += 1;
                } while(i < end);
            } else if(op == "-") {
                do {
                    if(i < num) {
                        Console.WriteLine("Nilai minus");
                        i += 1;
                    } else {
                        Console.WriteLine($"nilai i = {i} dan hasilnya {i-num}");
                        i += 1;
                    }
                } while(i < end);
            } else if(op == "*") {
                do {
                    Console.WriteLine($"nilai i = {i} dan hasilnya {i*num}");
                    i += 1;
                } while(i < end);
            } else if(op == "/") {
                do {
                    Console.WriteLine($"nilai i = {i} dan hasilnya {i/num}");
                    i += 1;
                } while(i < end);
            }
           
        }
    }