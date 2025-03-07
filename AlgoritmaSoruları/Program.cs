using System;
using System.Runtime.CompilerServices;

namespace AlgoritmaSoruları
{
    internal class Program
    {
        #region
        //static void Main(string[] args)
        //{
        //    Console.Write("Kaç sayı gireceksiniz? ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    int[] sayidizisi = new int[sayi]; 

        //    for (int i = 0; i < sayi; i++) 
        //    {
        //        Console.Write($"Dizinin {i + 1}. elemanını girin: ");
        //        sayidizisi[i] = Convert.ToInt32(Console.ReadLine()); 
        //    }

        //    Console.WriteLine("\nÇift Sayılar:");
        //    IsEvenNumber(sayidizisi, 0);          


        //}


        //static void IsEvenNumber(int[] dizi, int index)
        //{
        //    if (index >= dizi.Length)
        //        return;

        //    if (dizi[index] % 2 == 0) 
        //        Console.WriteLine(dizi[index]);

        //    IsEvenNumber(dizi, index + 1); 
        //}

        #endregion ALGORİTMA SORU 1
        #region
        //static void Main(string[] args)
        //{
        //    Console.Write("Pozitif bir n sayısı girin: ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Pozitif bir m sayısı girin: ");
        //    int m = Convert.ToInt32(Console.ReadLine());

        //    if (n <= 0 || m <= 0)
        //    {
        //        Console.WriteLine("Lütfen pozitif sayılar girin.");
        //        return;
        //    }
        //    List<int> numbers = new List<int>();
        //    Console.WriteLine($"Lütfen {n} adet pozitif sayı girin:");
        //    GetNumbers(numbers, n, 1);

        //    Console.WriteLine("m'e eşit veya tam bölünen sayılar:");
        //    PrintDivisibleNumbers(numbers, m, 0);
        //}

        //static void GetNumbers(List<int> numbers, int count, int index)
        //{
        //    if (count == 0) return;

        //    Console.Write($"Sayı {index}: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num > 0)
        //    {
        //        numbers.Add(num);
        //        GetNumbers(numbers, count - 1, index + 1);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Lütfen pozitif bir sayı girin!");
        //        GetNumbers(numbers, count, index);
        //    }
        //}

        //static void PrintDivisibleNumbers(List<int> numbers, int m, int index)
        //{
        //    if (index >= numbers.Count) return;

        //    if (numbers[index] == m || numbers[index] % m == 0)
        //    {
        //        Console.WriteLine(numbers[index]);
        //    }

        //    PrintDivisibleNumbers(numbers, m, index + 1);
        //}
        #endregion
        #region

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Pozitif bir sayı giriniz:");
        //    int psayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Girdiğiniz sayı kadar sözcük giriniz:");
        //    List<string> sozcukler = new List<string>();

        //    for (int i = 0; i < psayi; i++)
        //    {
        //        Console.WriteLine($"Lütfen {i+1}. sözcüğü giriniz");
        //        string sozcuk = Console.ReadLine();
        //        sozcukler.Add(sozcuk);
        //    }
        //    Console.WriteLine("Girilen sözcükler: " + string.Join(", ", sozcukler));
        //    List<string> reversedWords = ReverseWords(sozcukler);

        //    Console.WriteLine("Ters sıralanmış sözcükler: " + string.Join(", ", reversedWords));

        //}
        //static List<string> ReverseWords(List<string> sozcukler)
        //{
        //    sozcukler.Reverse(); 
        //    return sozcukler;
        //}
        #endregion
        
        static void Main(string[] args)
        {
            Console.WriteLine("Gireceğiniz cümledeki toplam kelime ve harf sayısını hesaplayacağım");
            Console.WriteLine("Lütfen işlem için bir cümle yazınız");
            string cumle = Console.ReadLine();

            int wordCount = CountWord(cumle);
            int letterCount = CountLetters(cumle);

            Console.WriteLine($"Toplam kelime sayısı {wordCount}");
            Console.WriteLine($"Toplam harf sayısı {letterCount}");

        }
        static public  int CountWord(string cumle)
        {
            if (string.IsNullOrEmpty(cumle)) { return 0; }

            string[] sozcukler = cumle.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return sozcukler.Length;

        }
        static int CountLetters(string sentence)
        {
            int count = 0;
            foreach (char c in sentence)
            {
                if (char.IsLetter(c))
                    count++;
            }
            return count;
        }

        
            


    }
    






}







