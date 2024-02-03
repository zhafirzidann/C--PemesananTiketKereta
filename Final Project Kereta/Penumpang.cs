using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_projek_ku_kereta
{
    //Turunan dari class vaksin
    class Vaksin : vaksin
    {

    }

    //Turunan dari class vaksin
    class Vaksin2 : vaksin
    {
        public void getVaksin()
        {
            Console.WriteLine(" Vaksin Ke-3 = Sudah");
        }
    }
    //implementasi interfaces
    internal class Penumpang : Data
    {

        //implementasi anggota interfaces / method
        public void ShowData(string Nama, int Nik, string Alamat, string Nohp, int Novaksin)
        {
            Console.WriteLine();
            Console.WriteLine(" Biodata Penumpang");
            Console.WriteLine(" Nama anda : {0}", Nama);
            Console.WriteLine(" Nik  : {0}", Nik);
            Console.WriteLine(" Alamat  : {0}", Alamat);
            Console.WriteLine(" Nohp : {0}", Nohp);
            Console.WriteLine(" No Vaksin Ke 2  : {0}", Novaksin);
        }
    }

    //Generic Class
    class Penumpang<T>
    {
        public T value;

        public Penumpang(T parameter)
        {
            this.value = parameter;
        }
    }
}
