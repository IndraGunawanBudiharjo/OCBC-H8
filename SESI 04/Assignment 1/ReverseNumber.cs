using System;

    public class ReverseNumber
    {
        public static void Main(string[] args)
        {
            string result = "";
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            
            int length = number.Length - 1;
        
            while(length >= 0)
            {
                result += number[length];
                length -= 1;
            }
            
            Console.WriteLine($"Reversed number: {result}");
        }
    }