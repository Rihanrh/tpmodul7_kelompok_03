﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_03
{
    public class Kmhs
    {
        public List<Course> courses { get; set; }
        public Kmhs() { }

        public Kmhs(List<Course> courses)
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

    internal class KuliahMahasiswa1302210028
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\RH\\Documents\\GitHub\\tpmodul7_kelompok_03\\tpmodul7_kelompok_03\\tp7_2_1302210028.json");
            Kmhs course = JsonSerializer.Deserialize<Kmhs>(jsonString);
            int i = 1;
            foreach (Course courses in course.courses)
            {
                Console.WriteLine("MK " + i + " " + courses.code + " - " + courses.name);
                i++;
            }
        }
    }
}
