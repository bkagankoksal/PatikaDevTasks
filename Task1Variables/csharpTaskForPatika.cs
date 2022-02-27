using System;

namespace CsharpTaskForPatika
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patika Task 1");
            string degisken = " ";

            byte b = 5; // byte ve sbyte bellekte 1 byte yer kaplar, 0 ile 255 arası değer alabilir
            sbyte c = 5; // -128 ile 127 arası değer alablir

            short s = 5; // short ve ushort bellekte 2 byte yer kaplar. -32768 ile + 32768 arası değer alır
            ushort us = 5; // 0 ile 65365 arası değer alır

            Int16 i16 = 2; // bellekte 2 byte yer kaplar
            int i = 7; // bellekte 4 byte yer kaplar
            Int32 i32 = 26; // bellekte 4 byte yer kaplar
            Int64 i64 = 69; // bellekte 8 byte yer kaplar
            
            uint ui = 4; //4 byte

            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            //reel sayılar için
            float f = 7; //4 byte
            double d = 5; // 8 byte
            decimal de = 6; //16 byte

            char char1 = '2'; // 2byte
            string str = "Patika Ödev"; //sınırsız

            bool bool1 = true;
            bool bool2 = false;

            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);

            object o1 = "x";
            object o2 = 'c';
            object o3 = 4.2;
            object o4 = 6;

            //STRINGLER
            string str1 = "";
            string str2 = string.Empty; // string içi boşsa böyle bir tanımlama yapılabilir
            str2 = "Patika";
            string str3 = "C# 101 Task";
            string fullstr = str2 + " " + str3;

            //INTEGER
            int sayi1 = 5;
            int sayi2 = 3;
            int sayiCarpim = sayi1 * sayi2;

            //BOOLEAN
            bool bool3 = sayi1 < sayi2;

            //DEĞİŞKEN DÖNÜŞÜMLERİ
            string str20 = "20";
            int i20 = 20;
            string concatStr = str20 + i20.ToString(); // cocantStr = 2020

            int i21 = i20 + Convert.ToInt32(str20); // i21 = 40

            int i22 = i20 + int.Parse(str20); // i22 = 40

            //DATETIME
            string tarih1 = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
