using System;

    public class Factorial
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if(num < 0) {
                Console.WriteLine(0);
            } else if(num == 0 || num == 1) {
                Console.WriteLine(1);
            } else {
                int result = 1;
                while(num > 1){
                    result *= num;
                    num -= 1;
                }
            Console.WriteLine(result);
            }
        }
    }