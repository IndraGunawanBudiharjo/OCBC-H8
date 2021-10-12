using System;

    public class HitungNilai4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "OCBC";

            if(isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else 
            {
                Console.WriteLine("Sorry, try again!");
            }
            
        }
    }