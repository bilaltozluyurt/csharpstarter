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
                Console.WriteLine("Diziye {0}. sayıyı giriniz :", i + 1);
                sayidizi[i] = int.Parse(Console.ReadLine());

            }
            double toplam = 0;
            foreach (var sayi in sayidizi)
            {
                toplam += sayi;

            }
            Console.WriteLine("Ortalama :" + toplam / dizilength);

            Console.WriteLine("UNSORTED");
            int[] ndizi = { 14, 25, 88, 91, 63, 28, 42, 9, 50 };
            foreach (var sayi in ndizi)
                Console.WriteLine(sayi);
            //SORTED
            Console.WriteLine("SORTED");
            Array.Sort(ndizi);
            foreach (var sayi in ndizi)
                Console.WriteLine(sayi);
            //REVERSE   
            Console.WriteLine("REVERSE");
            Array.Reverse(ndizi);
            foreach (var sayi in ndizi)
                Console.WriteLine(sayi);
            //CLEAR
            Console.WriteLine("CLEAR");
            Console.WriteLine("array.clear fonksiyonu test");
            Array.Clear(ndizi, 2, 3);
            foreach (var sayi in ndizi)
                Console.WriteLine(sayi);
            //indexof  
            Console.WriteLine("INDEXOF");
            // dizide 9 elemanı kaçıncı indexte
            Console.WriteLine(Array.IndexOf(ndizi, 9));
            //dizide olmayan eleman arayalım
            Console.WriteLine(Array.IndexOf(ndizi, 100));
            //aradığımız eleman dizide yoksa -1 değeri dönüyor.

            //RESIZE 
            int[] boyut = new int[10];
            Array.Resize<int>(ref boyut, 101);
            Random rn = new Random();
            for (int i = 0; i < boyut.Length; i++)
            {

                int deger=rn.Next(0, 200);
                boyut[i] = deger;
            }
            for (int j = 0; j < boyut.Length; j++)
            {
                Console.WriteLine(boyut[j]);
            }
            
            Array.Resize<int>(ref boyut,101);

            

        }
    }
}
