using System;

namespace pro6
{
        public class PesawatTempur : Pesawat
        {

            public PesawatTempur(string newNama, string newKetinggian, int newJumlahPenumpang, int newJumlahRoda) 
            {
                this.nama = newNama;
                this.ketinggian = newKetinggian;
                this.JumlahPenumpang = newJumlahPenumpang;
                this.jumlahRoda = newJumlahRoda;
            }
            public override void Terbang()
            {
                Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
            }
        }

        

}
    