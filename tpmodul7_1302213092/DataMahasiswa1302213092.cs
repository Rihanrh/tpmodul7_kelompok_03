using System;
using System.Text.Json;
namespace tpmodul7_1302213092;

public class DataMahasiswa1302213092
{
   Mahasiswa mahasiswa = new Mahasiswa();

    public DataMahasiswa1302213092()
    {

    }

    string text = File.ReadAllText("C:\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak\\GitHub\\tpmodul7_1302213092\\tpmodul7_1302213092\\tp7_1_13002213092.json");

    public void readJson()
    {
        mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(text);
        Console.WriteLine($"Nama: {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
        Console.WriteLine($"NIM: {mahasiswa.nim}");
        Console.WriteLine($"Fakultas: {mahasiswa.fakultas}");
    }
}
