using System;

namespace whileforeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak console'dan girilen sayıya kadar ort hesaplayıp console'a yazdırma
            Console.WriteLine("bir sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);
            char ch = 'a';
            while (ch <= 'z')
            {
                Console.Write(ch);
                
                ch++;
            }
            Console.WriteLine(" ");
            //FOREACH   
            string[] sehirler = {"Ankara", "İstanbul", "Londra", "Kaliforniya", "Münih"};
            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}