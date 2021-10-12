using System;

    public class Logika3
    {
        public static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            if(username == "indra" && password == "ocbc") {
                Console.WriteLine("Anda berhasil login");
            }
            else {
                Console.WriteLine("Username atau password anda salah");
            }

        }

    }
