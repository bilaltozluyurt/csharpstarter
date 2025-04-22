using System;

namespace DateTimeMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            int skt = 12;
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);//Yılın kaçıncı günü
            Console.WriteLine(DateTime.Now.ToLongDateString());//tarih
            Console.WriteLine(DateTime.Now.ToShortDateString());//**.**.****
            Console.WriteLine(DateTime.Now.ToLongTimeString());// saat,dk,sn
            Console.WriteLine(DateTime.Now.ToShortTimeString());// saat dk
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(10));
            Console.WriteLine(DateTime.Now.AddMonths(skt));
            Console.WriteLine(DateTime.Now.AddYears(7));
            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyy"));

            //Math

            Console.WriteLine(Math.Abs(-8)); //mutlak 8
            Console.WriteLine(Math.Sin(55));
            Console.WriteLine(Math.Cos(55));
            Console.WriteLine(Math.Tan(55));
            Console.WriteLine(Math.SinCos(55));
            Console.WriteLine(Math.Cosh(55));
            Console.WriteLine(Math.Ceiling(10.4));//11yukarı yuvarlar her zaman
            Console.WriteLine(Math.Round(10.7));// normal çalışır
            Console.WriteLine(Math.Floor(10.7));//10'a yuvarlar her zaman
            Console.WriteLine(Math.Min(10,15));
            Console.WriteLine(Math.Max(10,15));
            Console.WriteLine(Math.Pow(3,4));// 3^4 
            Console.WriteLine(Math.Sqrt(9));// kök 9 = 3
            Console.WriteLine(Math.Log(9));// log e tabanında 9
            Console.WriteLine(Math.Exp(3));// e^3
            Console.WriteLine(Math.Log10(10));// log 10 10 =1

        }
    }
}