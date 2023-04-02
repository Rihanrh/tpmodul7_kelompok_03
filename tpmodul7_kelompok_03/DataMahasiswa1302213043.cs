using System;
using System.Text.Json;

public class DataMahasiswa_1302213043
{
    public void ReadJSON()
    {
        string JSONfolder = File.ReadAllText("C:\\Users\\USER\\Documents\\KONSTRUKSI PERANGKAT LUNAK\\TP MOD 7\\tpmodul7_kelompok_03\\tpmodul7_kelompok_03\\tp7_1_1302213043.json");
        Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(JSONfolder);

        Console.Write("nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang);
        Console.Write(" dengan nim " + mahasiswa.nim);
        Console.WriteLine(" dari fakultas " + mahasiswa.fakultas);

    }
}

public class Mahasiswa
{
    public NamaLengkap nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public Mahasiswa() { }

    public Mahasiswa(NamaLengkap nama, int nim, string fakultas)
    {
        this.nama = nama;
        this.nim = nim;
        this.fakultas = fakultas;
    }
}

public class NamaLengkap
{
    public string depan { get; set; }
    public string belakang { get; set; }

    public NamaLengkap() { }

    public NamaLengkap(string depan, string belakang)
    {
        this.depan = depan;
        this.belakang = belakang;
    }
}