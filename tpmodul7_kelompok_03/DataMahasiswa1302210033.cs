using System;
using System.Text.Json;

public class DataMahasiswa1302210033
{
	public void ReadJSON()
	{
		String json = File.ReadAllText("C:\\Users\\Asus\\Documents\\Lia\\Telkom\\SEMS 4\\KPL\\TP\\TPMOD7\\tpmodul7_kelompok_03\\tpmodul7_kelompok_03\\tp7_1_1302210033.json");

		Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json);

		Console.WriteLine("Nama {0:s} {1:s} dengan nim {2:d} dari fakultas {3:s}",
			mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.NIM, mahasiswa.fakultas);

	}
}

public class Mahasiswa
{
	public Nama nama { get; set; }

	public int NIM { get; set; }

	public string fakultas { get; set; }

	public Mahasiswa() { }
	public Mahasiswa(Nama nama, int NIM, string fakultas)
	{
		this.nama = nama;
		this.NIM = NIM;
		this.fakultas = fakultas;
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
