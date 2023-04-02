using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    internal class KuliahMahasiswa1302213037
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\Tugasgasgas\\TEL-U\\Matakuliah\\S4\\KPL\\TP-TP\\TP_MOD7_1302213037\\tpmodul7_kelompok_03\\tp7_2_1302213037.json");
            ListKuliah course = JsonSerializer.Deserialize<ListKuliah>(jsonString);

            Console.WriteLine("Daftar matakuliah yang diambil :");
            int i = 1;
            foreach(Course courses in course.courses)
            {
                Console.WriteLine("MK " + i +" " + courses.code + " - " + courses.name);
                i++;
            }
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

    public class ListKuliah
    {
        public List<Course> courses { get; set;}
        public ListKuliah() { }

        public ListKuliah(List<Course> courses)
        {
            this.courses = courses;
        }
    }
}
