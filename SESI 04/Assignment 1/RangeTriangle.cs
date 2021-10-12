using System;

    public class RangeTriangle
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the Range = ");
            int range = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < range; i++){
                for(int j = 0; j < range - i - 1; j++){
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++) {
                    Console.Write(1+k);
                }
                for(int l = i-1; l >= 0; l--){
                    Console.Write(1+l);
                }
                Console.WriteLine("");
            }
        }
    }