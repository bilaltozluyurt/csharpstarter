using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;     //1byte
            sbyte c = 1;    //1byte

            short s = 1;    //2byte
            ushort us = 1;   //2byte

            Int16 i16 = 16;  //2byte
            int i = 1;      //4byte
            Int32 i32 = 32;  //4byte
            Int64 i64 = 64;  //8byte

            uint ui = 2;    //4byte
            long l = 4;     //8byte
            ulong ul = 4;   //8byte
            Console.WriteLine(s);

            //Real sayılar
            float f = 1;    //4byte
            double d = 1;   //8byte
            decimal de = 1; //16byte

            char ch = '1';  //2byte
            string sr = "lorem ipsum dolor";  //Sınırsız

            bool b1 = true;
            bool b2 = false;


            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "bilal furkan";
            string ad = "bilal";
            string soyad = "furkan";
            string tamIsim = ad + " " + soyad;

            //Integer

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean

            bool bool1 = 10 > 2;

            //Değişken Dönüşümleri
            string str20 = "30";
            int int20 = 20;
            string yeni = str20 + int20.ToString();
            Console.WriteLine(yeni);   //2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);   //= 50

            //datetime

            string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt1);

            string dt2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dt2);

            string dt3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dt3);



        }
    }
}