using System;

namespace MyApp
{
    internal class trycatchfinally
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı:"+ sayi);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Hata:"+ ex.Message.ToString());
                
            }
            finally 
            {  
                //kod bloğu hata alsa da almasa da çalışır
                Console.WriteLine("işlem Tamamlandı");
                // bu kod bloğu kullanılmak zorunda değil.
            }
           
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
                               
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Uygunsuz veri tipi");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
        }
    }
}