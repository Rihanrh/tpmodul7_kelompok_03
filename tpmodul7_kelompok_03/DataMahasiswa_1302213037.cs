using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    internal class DataMahasiswa_1302213037
    {

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Tugasgasgas\\TEL-U\\Matakuliah\\S4\\KPL\\TP-TP\\TP_MOD7_1302213037\\tpmodul7_kelompok_03\\tp7_1_1302213037.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("Nama " + mhs.nama.depan + " " + mhs.nama.belakang +" dengan nim " + mhs.nim + " dari fakultas " + mhs.fakultas);
        }
    }
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
        public Nama() { }

        public Nama(string depan, string belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }

        public Mahasiswa() { }
        public Mahasiswa(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
    }
}
