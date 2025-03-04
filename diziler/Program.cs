using System;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            //değer atama
            renkler[0] = "Kırmızı";
            renkler[1] = "Siyah";

            int[] sayidizisi;
            sayidizisi = new int[7];
            string[] days = {"Sunday","Monday","Tuesday"
                    ,"Wednesday","Thursday","Friday","Saturday"};
            //erişim
            Console.WriteLine(days[3]);
            Console.WriteLine(renkler[0]);

            Console.WriteLine("Lütfen dizinin eleman sayısını girin");
            int dizilength = int.Parse(Console.ReadLine());
            int[] sayidizi = new int[dizilength];
            for (int i = 0; i < sayidizi.Length; i++)
            {
                Console.WriteLine("Diziye {0}. sayıyı giriniz :",i+1);
                sayidizi[i] = int.Parse(Console.ReadLine());

            }
            double toplam = 0;
            foreach (var sayi in sayidizi)
            {
                toplam += sayi;

            }
            Console.WriteLine("Ortalama :" +toplam/dizilength);
             

        }
    }
}