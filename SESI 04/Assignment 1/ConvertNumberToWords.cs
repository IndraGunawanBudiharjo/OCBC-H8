using System;

    public class ConvertNumberToWords
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();

            Console.WriteLine(convert(number.ToCharArray()));

        }

        public static string convert(char[] num) 
        {
        
            if(num.Length == 0) {
                return "Empty Words";
            }

            string[] single_digits = new string[] {
                "zero", "one", "two", "three", "four"
                , "five", "six", "seven", "eight", "nine"
            };

            string result = "";

            foreach(char n in num) {
                result += single_digits[n - '0'] + " ";
            }

            return result;
        }
    }