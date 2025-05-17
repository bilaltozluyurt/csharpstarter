using System.Security.Cryptography.X509Certificates;

namespace GenericCollectionsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // <T> object tipinde
            List<int> sayilistesi = new List<int>();
            sayilistesi.Add(1);
            sayilistesi.Add(4);
            sayilistesi.Add(8);
            sayilistesi.Add(12);
            sayilistesi.Add(17);
            sayilistesi.Add(3);
            sayilistesi.Add(5);
            sayilistesi.Add(97);
            sayilistesi.Add(2);
            sayilistesi.Add(37);

            List<string> renklist = new List<string>();
            renklist.Add("Kırmızı");
            renklist.Add("Kahverengi");
            renklist.Add("Mavi");
            renklist.Add("Siyah");
            renklist.Add("Mor");
            renklist.Add("Lacivert");
            renklist.Add("Beyaz");
            renklist.Add("Gri");
            renklist.Add("Turuncu");
            renklist.Add("Sarı");

            //Count 
            Console.WriteLine(renklist.Count);
            Console.WriteLine(sayilistesi.Count);

            foreach (var sayı in sayilistesi)
            {
                Console.WriteLine(sayı);
            }
            foreach (var renk in renklist)
            {
                Console.WriteLine(renk);
            }
            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklist.ForEach(renk => Console.WriteLine(renk));
            //Listeden eleman çıkarma 
            sayilistesi.Remove(4);
            renklist.Remove("Yeşil");
            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
            renklist.ForEach(renk => Console.WriteLine(renk));

            sayilistesi.RemoveAt(0);
            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
            sayilistesi.RemoveRange(3, 5);
            sayilistesi.ForEach(sayi => Console.WriteLine(sayi));
            //Listede Arama
            if (sayilistesi.Contains(10))
            {
                Console.WriteLine("Aranılan sayı bulundu");
            }
            else Console.WriteLine("Bulunamadı");

            //eleman ile indexe erişim
            Console.WriteLine(renklist.BinarySearch("Mavi"));
            Console.WriteLine(renklist.BinarySearch("Turuncu"));

            //diziyi liste çevirme 
            string[] hayvan = { "kedi", "köpek", "kuş", "balık" };
            List<string> hayvanlar = new List<string>(hayvan);

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Ad = "Bilal";
            kullanıcı1.Soyad = "Tozluyurt";
            kullanıcı1.Yas = 27;
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Ad = "Furkan";
            kullanıcı2.Soyad = "Tozluyurt";
            kullanıcı2.Yas = 27;

            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
            {
                Ad = "Mustafa Kemal",
                Soyad = "Atatürk",
                Yas = 58

            });
            foreach (var kullanıcı in kullanıcılistesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Ad);
                Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.Soyad);
                Console.WriteLine("Kullanıcı yaşı:"+kullanıcı.Yas);
            }
        }
        public class Kullanıcılar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Ad { get => isim; set => isim = value; }
            public string Soyad { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }

        }

    }
    
}