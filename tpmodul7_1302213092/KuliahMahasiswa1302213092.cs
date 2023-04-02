using System;
using System.Text.Json;
using System.IO;
namespace tpmodul7_1302213092;

public class KuliahMahasiswa1302213092
{
	ListCourse matkul = new ListCourse();

	public void readJSON()
	{
		string text2 = File.ReadAllText("C:\\Kuliah\\Semester 4\\Konstruksi Perangkat Lunak\\GitHub\\tpmodul7_1302213092\\tpmodul7_1302213092\\tp7_2_1302213092.json");

		matkul = JsonSerializer.Deserialize<ListCourse>(text2);

		for(int i = 0; i < matkul.courses.Count; i++)
		{
			Console.WriteLine($"MK {i+1}: <{matkul.courses[i].code}> - <{matkul.courses[i].name}>");
		}
	}
	public KuliahMahasiswa1302213092()
	{
	}
}
