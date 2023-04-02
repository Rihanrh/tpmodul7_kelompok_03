using System;
using System.Text.Json;

public class KuliahMahasiswa1302210033
{
	public void ReadJSON()
	{
        String json = File.ReadAllText("C:\\Users\\Asus\\Documents\\Lia\\Telkom\\SEMS 4\\KPL\\TP\\TPMOD7\\tpmodul7_kelompok_03\\tpmodul7_kelompok_03\\tp7_2_1302210033.json");

        Kuliah course = JsonSerializer.Deserialize<Kuliah>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        int i = 1;

        foreach(Course courses in course.courses)
        {
            Console.WriteLine("MK {0:d} {i:s} - {2:s}",1, courses.code,courses.name);
            i++;
        }
       
    }
}
public class Kuliah
{
    public List<Course> courses { get; set; }

    public Kuliah() { }

    public Kuliah(List<Course> courses)
    {
        this.courses = courses;
    }
}
public class Course
{

    public string code { get; set; }
    public string name { get; set; }

    public Course() { }

    public Course(string code, string name)
    {
        this.code = code;
        this.name = name;
    }
}
