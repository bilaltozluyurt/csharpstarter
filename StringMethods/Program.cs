using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Lorem ipsum";
            string d2 = "Balık";
            string d3 = "Lorem ipsum";
            //Length
            Console.WriteLine(degisken.Length);
            //ToUpper , ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper(new System.Globalization.CultureInfo("en-EN")));

            //Concat
            Console.WriteLine(String.Concat(degisken," dolor"));
            //Compare CompareTo
            Console.WriteLine(degisken.CompareTo(d3)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,d3,true));
            //true = büyük küçük harf duyarsız
            //false= büyük küçük harf duyarlı

            //Contains      
            Console.WriteLine(degisken.Contains(d3));
            Console.WriteLine(degisken.EndsWith("ipsum"));
            Console.WriteLine(degisken.StartsWith("L"));

            //Indexof
            Console.WriteLine(degisken.IndexOf("Lor"));
            Console.WriteLine(d2.IndexOf("L"));//büyük küçük harf duyarlı
            Console.WriteLine(d2.IndexOf("k"));//indexini döndü

            //insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));
            //LastIndexOf aranan harfin bulunduğu son indexi getirir
            Console.WriteLine(degisken.LastIndexOf("i"));


            //PadLeft, Padright
            Console.WriteLine(degisken + d2.PadLeft(30,'*'));
            //30 tamamlayacak kadar boşluk ekledik 

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(0,3));
            //0. indexten sonra 3 index sildi
            //10. indexten sonrasını tamamen sildi

            //Replace   
            Console.WriteLine(degisken.Replace("Lorem","Hello World"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));




            


        }
    }
}