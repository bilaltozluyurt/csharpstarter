using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();
            c1.ad = "bilal";
            c1.soyad = "furkan";
            c1.no = 1234589;
            c1.departman = "Developer";
            c1.CalisanBilgi();
            Calisan c2 = new Calisan();
            c2.ad = "bilal furkan";
            c2.soyad = "tozluyurt";
            c2.no = 1234582;
            c2.departman = "Developer";
            c2.CalisanBilgi();
        }
    }
}
class Calisan 
{
    public string ad;

    public string soyad;
    public int no;
    public string departman;

    public void CalisanBilgi()
    {
        Console.WriteLine("Çalışan Ad {0}", ad);
        Console.WriteLine("Çalışan soyAd{0}", soyad);
        Console.WriteLine("Çalışan no {0}", no);
        Console.WriteLine("Çalışan departman{0}", departman);
    }
}