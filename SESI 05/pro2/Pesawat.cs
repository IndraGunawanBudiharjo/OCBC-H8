using System;

namespace pro2
{
    public class Pesawat
    {
        public string nama;
        private string ketinggian;
        
        public Pesawat(string newNama, string newKetinggian)
        {
            this.nama = newNama;
            this.ketinggian = newKetinggian;
        }

        // getter dan setter
        public string Ketinggian
        {
            get { return this.ketinggian; }
            set { this.ketinggian = value; }
        }

        public void Terbang() 
        {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
        }

        public void SudahTerbang()
        {
            Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
        }
    }
}
    