using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time > 6 && time <= 12)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time > 12 && time <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else
            {
                Console.WriteLine("İyi geceler");
            }
            Console.WriteLine(time > 6 && time <= 12 ? "Günaydın" : time > 12 && time <= 18 ? "İyi günler" : time > 18 ? "İyi geceler" : "İyi geceler"); 
        }
    }
}