using System;

namespace metotoverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OUT PARAMETRE
            string sayi = "99";
            int outSayi;
            bool result = int.TryParse(sayi,out outSayi);
            if (result)
            {
                Console.WriteLine("Başarılı ");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar mt = new Metotlar();
            mt.Sum(4, 5, out int resultsum);
            Console.WriteLine(resultsum);
            // METOT OVERLOAD 
            int ifade = 1111;
            mt.EkranYaz(Convert.ToString(ifade));


        }
        class Metotlar
        {//OUT PARAMETRE ÖRNEK
            public void Sum(int a, int b,out int topla)
            {
                topla = a + b;
            }
            public void EkranYaz(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranYaz(int veri)
            {
                Console.WriteLine(veri);
            }
        }
    }
}