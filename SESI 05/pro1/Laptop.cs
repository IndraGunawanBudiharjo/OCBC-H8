using System;

namespace pro1{
    public class Laptop 
    {
        // instance variable
        public string merk;
        public int ram;
        public int memory;

        // constructor

        public Laptop(string newMerk, int newRam, int newMemory) 
        {
            this.merk = newMerk;
            this.ram = newRam;
            this.memory = newMemory;
        }

        // method

        public void Chatting()
        {
            Console.WriteLine("\n{0} sedang chatting", this.merk);
        }

        public void Sosmed()
        {
            Console.WriteLine("{0} sedang sosmed", this.merk);
        }

        public void OnlineShop()
        {
            Console.WriteLine("{0} sedang online shop", this.merk);
        } 

    }
}
