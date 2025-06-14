using System;
using System.Collections;

namespace arraylist

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add('A');
            liste.Add(true);

            //erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //adrange
            string[] renk = { "kırmızı", "mavi", "siyah", "yeşil" };
            List<int> sayı = new List<int>() {1,3,5,7,8,9,11,64,32,16,128};
            liste.AddRange(renk);
            liste.AddRange(sayı);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort
            //liste.Sort();
            //system.invalidoperationexpection 

            //Console.WriteLine(liste.BinarySearch(1));

            //clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}