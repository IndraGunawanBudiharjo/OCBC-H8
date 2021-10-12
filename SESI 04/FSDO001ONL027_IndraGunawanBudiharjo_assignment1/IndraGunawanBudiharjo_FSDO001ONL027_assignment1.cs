using System;

    public class IndraGunawanBudiharjo_FSDO001ONL027_assignment1 
    {
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

        public static void printSpaces(int i, int len)
        {
            for(int j = 0; j < len - i - 1; j++){
                Console.Write(" ");
            }
        }

        public static void printTriangleAlphabet1(int i) 
        {
            for(int k = 0; k <= i; k++) {
                Console.Write((char)(65+k));
            }
        }

        public static void printTriangleAlphabet2(int i)
        {
            for(int l = i-1; l >= 0; l--){
                Console.Write((char)(65+l));
            }
        }

        public static void printTriangle1(int i) 
        {
            for(int k = 0; k <= i; k++) {
                Console.Write(1+k);
            }
        }
        public static void printTriangle2(int i)
        {
            for(int l = i-1; l >= 0; l--){
                Console.Write(1+l);
            }
        }

        public static long factorial(long num) {
            long result = 1;

            if(num < 0) {
                return 0;
            } else if(num == 0 || num == 1) {
                return 1;
            } else {
                while(num > 1){
                    result *= num;
                    num -= 1;
                }
            }
            return result;
            
        }

        public static string reverseNumber(string number) {
            string result = "";
            int length = number.Length - 1;
        
            while(length >= 0)
            {
                result += number[length];
                length -= 1;
            }
            return result;
            
        }

        public static Boolean isPalindrome(string text) {
            int len = text.Length / 2;
            int i = 0;
            Boolean check = true;

            while(i <= len)
            {
                if(text[i] != text[text.Length-i-1]){
                    check = false;
                }
                i += 1;
            }
            return check;
            
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Assignment 1---");
            Console.WriteLine("Nama: Indra Gunawan Budiharjo");
            Console.WriteLine("Nomor Peserta: FSDO001ONL027");
            Console.WriteLine("Alamat: Malang");
            Console.WriteLine("");

            while(true) {
                
                Console.WriteLine("Menu Assignment 1: ");
                Console.WriteLine("1. Alphabet Triangle");
                Console.WriteLine("2. Range Triangle");
                Console.WriteLine("3. Factorial");
                Console.WriteLine("4. Reverse Number");
                Console.WriteLine("5. Convert Number to Words");
                Console.WriteLine("6. Is Palindrome?");
                Console.WriteLine("7. Exit");
                Console.Write("Entry your choice: ");
                string choose = Console.ReadLine();

                if(choose == "7") {
                    Console.WriteLine("Thank you for checking my assignment");
                    break;
                }

                if(choose == "1") {
                    Console.Write("Enter the length = ");
                    int len = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < len; i++) {
                        printSpaces(i, len);
                        printTriangleAlphabet1(i);
                        printTriangleAlphabet2(i);
                        Console.WriteLine("");
                    }

                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                } 
                
                if(choose == "2") {
                    Console.Write("Enter the length = ");
                    int len = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < len; i++){
                        printSpaces(i, len);
                        printTriangle1(i);
                        printTriangle2(i);
                        Console.WriteLine("");
                    }
                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                } 
                
                if(choose == "3") {
                    Console.Write("Enter any number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    long result = factorial(num);

                    Console.WriteLine($"Factorial of {num} is: {result}");

                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(choose == "4") {
                    Console.Write("Enter a number: ");
                    string number = Console.ReadLine();
                    string result = reverseNumber(number);
                    Console.WriteLine($"Reversed number: {result}");

                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(choose == "5") {
                    Console.Write("Enter the number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine(convert(number.ToCharArray()));

                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }

                if(choose == "6") {
                    Console.Write("Enter a string: ");
                    string text = Console.ReadLine();

                    Boolean result = isPalindrome(text);

                    Console.WriteLine($"isPalindrome? : {result}");

                    Console.Write("Back to menu?(y/n)");
                    string back = Console.ReadLine();
                    if(back == "y") {
                        Console.Clear();
                        continue;
                    } else {
                        Console.WriteLine("Thank you for checking my assignment");
                        break;
                    }
                }
                
            }
            
        }
    }