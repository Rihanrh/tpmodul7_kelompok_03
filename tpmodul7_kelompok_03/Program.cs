
using tpmodul7_kelompok_03;

class Program
{
    public static void Main(string[] args)
    {
        //Rihan
        DataMahasiswa1302210028 dmRihan = new DataMahasiswa1302210028();
        dmRihan.ReadJSON();
        
        KuliahMahasiswa1302210028 kmRihan = new KuliahMahasiswa1302210028();
        kmRihan.ReadJSON();
        Console.WriteLine("");
        
        //Liyan
        DataMahasiswa_1302213037 mhsL = new DataMahasiswa_1302213037();
        mhsL.ReadJSON();
        
        KuliahMahasiswa1302213037 ListMatakuliah = new KuliahMahasiswa1302213037();
        ListMatakuliah.ReadJSON();
        Console.WriteLine("");
        
    }
}
