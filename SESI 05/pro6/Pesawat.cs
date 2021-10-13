using System;

namespace pro6
{
        public class Pesawat
        {
            protected string nama;
            protected string ketinggian;
            protected int jumlahPenumpang;
            protected int jumlahRoda;

        // getter dan setter
             public string Nama
            {
                get { return this.nama; }
                set { this.nama = value; }
            }
            public string Ketinggian
            {
                get { return this.ketinggian; }
                set { this.ketinggian = value; }
            }

            public int JumlahPenumpang
            {
                get { return this.jumlahPenumpang; }
                set { this.jumlahPenumpang = value; }
            }

            public int JumlahRoda
            {
                get { return this.jumlahRoda; }
                set { this.jumlahRoda = value; }
            }

            public virtual void Terbang() 
            {
                Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
            }

        }

}
    