// See https://aka.ms/new-console-template for more information
public class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213043 dataMahasiswa = new DataMahasiswa_1302213043();
        dataMahasiswa.ReadJSON();

        KuliahMahasiswa_1302213043 mataKuliah = new KuliahMahasiswa_1302213043();
        mataKuliah.ReadJSON();
    }
}