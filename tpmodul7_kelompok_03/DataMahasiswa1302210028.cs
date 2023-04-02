using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class Mahasiswa
    {
        public Nama nama {  get; set; }
        public int nim { get; set; }
        public string fakultas { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(Nama nama, int nim, string fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
    }

    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public Nama() { }

        public Nama(string depan, string belakang)        {
            this.depan = depan;
            this.belakang = belakang;
        }

    }
    internal class DataMahasiswa1302210028
    {
        
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\RH\\Documents\\GitHub\\tpmodul7_kelompok_03\\tpmodul7_kelompok_03\\tp7_1_1302210028.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
            Console.WriteLine("Nama " + mhs.nama.depan + " " + mhs.nama.belakang +
                " dengan nim " + mhs.nim + " dari fakultas " + mhs.fakultas);
        }
    }
}
