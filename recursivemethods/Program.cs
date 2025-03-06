using System;

namespace recursivemethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recursive öz yineleme

            //3^4 for ile 
            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            Islem instance = new Islem();
            Console.WriteLine(instance.Expo(3,4));


            //EXTENSION METHODS
            string ifade = "Bilal Furkan";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces());
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] arry = { 1, 2, 4, 891, 7278, 301, 542, 427, 413, 383, 2478, 1881 };
            arry.SortArray();
            arry.EkranaYaz();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }
    public class Islem
    {
        public int Expo(int sayi,int üs) 
        {
            if (üs<2)
            {
                return sayi;
            }
            return Expo(sayi, üs - 1)*sayi;
        
        }

    }
    public static class Extension
    {
        public static void EkranaYaz(this int[] param)
        {
            foreach(int item in param)
            {
                Console.Write(item);
            } 
        }
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");

            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();

        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();

        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static bool IsEvenNumber(this int param)
        {          
            
            return param % 2 == 0; 

        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);


        }




    }
}