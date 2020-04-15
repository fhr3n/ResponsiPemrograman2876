using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2876
{
    class Karyawan
    {
        public string nik;
        public string nama;
        public int gajibulanan;
        public Karyawan(string nik,string nama,int gajibulanan){
            this.nik=nik;
            this.nama=nama;
            if(gajibulanan<0){
                this.nik="0";
                Console.WriteLine("Maaf Gaji Yang Anda Masukkan Tidak boleh Kurang Dari 0");
            }
            else{
            this.gajibulanan=gajibulanan;
            }
        }
    }
}
