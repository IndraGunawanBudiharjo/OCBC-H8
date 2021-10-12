using System;
using System.Globalization;

namespace hello_cs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            // Console.WriteLine("Enter your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your address: ");
            string address = Console.ReadLine();

            var cultureInfo = new CultureInfo("de-DE");

            int now = DateTime.Now.Year;

            Console.WriteLine("Enter your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine(), cultureInfo);

            // Console.WriteLine(DateTime.Now.Year.GetType());
            // Console.WriteLine(birthDate.Year.GetType());
            Console.WriteLine("Your full name is " + firstName + " " + lastName);
            Console.WriteLine("Your age is " + (now - birthDate.Year));
            Console.WriteLine("Your address is " + address + " and your birthdate is " + birthDate.ToString("dd/MM/yyyy"));

        }
    }
}
