using System;

    public class Data2
    {
        public static void Main(string[] args)
        {
             string[] contoh = new string[4] 
            {
                "Motherboard", "Processor", "Power Supply", "Video Card"
            };

            string contoh1 = contoh[3];
            Console.WriteLine(contoh1);
            foreach(string c in contoh) {
                Console.WriteLine(c);
            }

            Console.Write("Press any key to continue...");

        }
       
    }