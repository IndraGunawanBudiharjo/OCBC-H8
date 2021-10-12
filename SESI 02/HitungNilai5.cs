using System;

    public class HitungNilai5
    {
        public static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Umur: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jenis Kelamin: ");
            string gender = Console.ReadLine();
            Console.Write("Status Nikah: ");
            bool nikah = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Aritmatika");
            Console.Write("nilai1: ");
            int nilai1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nilai2: ");
            int nilai2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nilai3: ");
            int nilai3 = Convert.ToInt32(Console.ReadLine());


            bool isUsernameValid = username == "indra";
            bool isPasswordValid = password == "ocbc";
            bool isAdult = age > 18;


            if(isUsernameValid && isPasswordValid && isAdult) 
            {
                Console.WriteLine();
                Console.WriteLine("Biodata");
                Console.WriteLine($"Umur anda: {age}");
                Console.WriteLine($"Username anda: {username}");
                Console.WriteLine($"Jenis kelamin anda: {gender}");
                Console.WriteLine($"Status nikah anda: {nikah ? "sudah" : "belum"}");
                Console.WriteLine();
                Console.WriteLine("Aritmatika");
                Console.WriteLine("Total nilai: " + (nilai1 + nilai2 + nilai3));
                Console.WriteLine("Rerata nilai: " + ((nilai1 + nilai2 + nilai3) / 3));
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("Sorry, try again!");
            }


        }
    }