﻿// See https://aka.ms/new-console-template for more information
namespace tpmodul7_1302213092;

class program
{
    public static void Main(string[] args)
    {
        //DataMahasiswa1302213092 data = new DataMahasiswa1302213092();
        //data.readJson();
        KuliahMahasiswa1302213092 coolyeah = new KuliahMahasiswa1302213092();
        coolyeah.readJSON();

        DataMahasiswa1302213092 data = new DataMahasiswa1302213092();
        data.readJson();
    }
}