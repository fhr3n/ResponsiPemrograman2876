using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2876
{
    class Program
    {
        static void Main(string[] args)
        {
            int g1, g2;
            Karyawan karyawan1 = new Karyawan("123123", "Fahren", 3000000);
            Karyawan karyawan2 = new Karyawan("345345", "Tifa", 2000000);
            Console.WriteLine("No Nik/nama        Gaji Bulanan");
            Console.WriteLine("===============================");
            Console.WriteLine("1. " + karyawan1.nik + " " + karyawan1.nama + "\t" + karyawan1.gajibulanan);
            Console.WriteLine("1. " + karyawan2.nik + " " + karyawan2.nama + "\t\t" + karyawan2.gajibulanan);
            Console.WriteLine("\n\nAsyiiiiik Ada Kenaikan Gaji 10%!!\n");
            Console.WriteLine("No Nik/nama        Gaji Bulanan");
            Console.WriteLine("===============================");
            g1 = (10 * karyawan1.gajibulanan) / 100;
            g2 = (10 * karyawan2.gajibulanan) / 100;
            Console.WriteLine("1. " + karyawan1.nik + " " + karyawan1.nama + "\t" + (g1 + karyawan1.gajibulanan));
            Console.WriteLine("1. " + karyawan2.nik + " " + karyawan2.nama + "\t\t" + (g2 + karyawan2.gajibulanan));

            Console.ReadKey();
        }
    }
}
