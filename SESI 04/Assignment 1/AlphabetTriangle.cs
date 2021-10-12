using System;

    public class AlphabetTriangle 
    {
        public static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++) {
                
                for(int j = 0; j < 5 - i - 1; j++){
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++) {
                    Console.Write((char)(65+k));
                }
                for(int l = i-1; l >= 0; l--){
                    Console.Write((char)(65+l));
                }
                Console.WriteLine("");
            }
        }
    }