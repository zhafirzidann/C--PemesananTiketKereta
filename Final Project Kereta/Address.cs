using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_projek_ku_kereta
{
    //Turunan dari abstract class Alamat
    class Address : Alamat
    {
        private int RT;
        private int RW;
        private string Kelurahan;
        private string Kecamatan;
        private string Kabupaten;
        private string Provinsi;
        private string Jalan;

        public Address(int RT, int RW, string Kelurahan, string Kecamatan, string Kabupaten, string Provinsi, string Jalan)
        {
            this.RT = RT;
            this.RW = RW;
            this.Kelurahan = Kelurahan;
            this.Kecamatan = Kecamatan;
            this.Kabupaten = Kabupaten;
            this.Provinsi = Provinsi;
            this.Jalan = Jalan;
        }

        //Dynamic Polymorphims
        public override int getRT()
        {
            return this.RT;
        }
        public override int getRW()
        {
            return this.RW;
        }
        public override string getKelurahan()
        {
            return this.Kelurahan;
        }
        public override string getKecamatan()
        {
            return this.Kecamatan;
        }
        public override string getKabupaten()
        {
            return this.Kabupaten;
        }
        public override string getProvinsi()
        {
            return this.Provinsi;
        }

        //static Polymorphism
        public virtual string getJalan()
        {
            return this.Jalan;
        }

        public void print()
        {
            Console.WriteLine($" RT : {RT}");
            Console.WriteLine($" RW : {RW}");
            Console.WriteLine($" Kelurahan : {Kelurahan}");
            Console.WriteLine($" Kecamatan : {Kecamatan}");
            Console.WriteLine($" Kabupaten : {Kabupaten}");
            Console.WriteLine($" Kabupaten : {Provinsi}");
            Console.WriteLine($" Jalan     : {Jalan}");

        }
    }

}
