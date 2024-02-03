using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_projek_ku_kereta
{

    //menggunakan konsep interfaces
    interface Data
    {
        void ShowData(string Nama, int Nik, string Alamat, string Nohp, int Novaksin);

    }

    //menggunakan konsep inheritance
    class vaksin
    {
        public void getVaksin()
        {
            Console.WriteLine(" Vaksin Ke-3 = Belum");
        }
    }

    //menggunakan konsep abstract
    abstract class Alamat
    {
        public abstract int getRT();
        public abstract int getRW();
        public abstract string getKelurahan();
        public abstract string getKecamatan();
        public abstract string getKabupaten();
        public abstract string getProvinsi();
    }
    public class program
    {
        static void Main(string[] args)
        {
            //Generic Class
            Kereta kereta1 = new Kereta("0001", "Argolawu");
            Penumpang<Kereta> penumpang1 = new Penumpang<Kereta>(kereta1);
            //Pemanggilan Generic Class
            Console.WriteLine("Penumpang  : {0}  | Kereta :{1}", penumpang1.value.NoPenumpang, penumpang1.value.kereta);
            Penumpang orang1 = new Penumpang();
            //Input Interfaces Class
            orang1.ShowData("fauzan", 347690123, "Sragen Dok", "089765436663", 9935);
            //Input Inheritance
            Vaksin datavaksin1 = new Vaksin();
            datavaksin1.getVaksin();
            //Input Abstract Class
            Address alamat1 = new Address(20, 07, "Sragen Wetan", "Sragen", "Sragen", "Jawa tengah", "Jl Sudirman");
            alamat1.print();

            Console.WriteLine("\n");
            //Generic Class
            Kereta kereta2 = new Kereta("0002", "Jayabaya");
            Penumpang<Kereta> penumpang2 = new Penumpang<Kereta>(kereta2);
            //Pemanggilan Generic Class
            Console.WriteLine("Penumpang  : {0}  | Kereta :{1}", penumpang2.value.NoPenumpang, penumpang2.value.kereta);
            Penumpang orang2 = new Penumpang();
            //Input Interfaces Class
            orang2.ShowData("Zidan", 347912002, "Perumahan GKP", "087842990875", 9876);
            //Input Inheritance
            Vaksin2 datavaksin2 = new Vaksin2();
            datavaksin2.getVaksin();
            //Input Abstract Class
            Address alamat2 = new Address(20, 07, "Argorejo", "Sedayu", "Bantul", "Yogyakarta", "Jl Wates");
            alamat2.print();
        }
    }

}
