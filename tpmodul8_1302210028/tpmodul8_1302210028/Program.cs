// See https://aka.ms/new-console-template for more information


using tpmodul8_1302210028;

public class Program
{
    public static void Main(string[] args)
    {
        Cconfig cc = new Cconfig();

        cc.UbahSatuan();

        Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai "+cc.config.satuan_suhu);
        double inputsuhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
        int inputhari = Convert.ToInt32(Console.ReadLine());

        if ((cc.config.satuan_suhu == "celcius" && inputsuhu >= 36.5 && inputsuhu <= 37.5)
            && inputhari < cc.config.batas_hari_demam)
        {
            Console.WriteLine(cc.config.pesan_diterima);
        }
        else if ((cc.config.satuan_suhu == "farenheit") && inputsuhu >= 97.7 && inputsuhu <= 99.5
            && inputhari < cc.config.batas_hari_demam)
        {
            Console.WriteLine(cc.config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(cc.config.pesan_ditolak);
        }
    }
}