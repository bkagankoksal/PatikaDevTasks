using System;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine(d);

            long l = d;
            Console.WriteLine(l);

            float f = l;
            Console.WriteLine(f);

            string str = "Implicit Conversions";
            char e = '1';
            object g = e + str + d;
            Console.WriteLine(g);

            // Explicit conversion
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 120;
            byte t = (byte)z;

            float w = 2.1f;
            byte v = (byte)w;
            Console.WriteLine(v); // float tipi bytea çevirince  virgüldn sonrasını almıyor

            // ToString()
            int x1 = 6;
            string str1 = x1.ToString();
            Console.WriteLine(str1);

            string str2 = 26.9f.ToString();
            Console.WriteLine(str2);

            // System.Convert
            string str11 = "10", str12 = "20";
            int sayi1, sayi2;
            int sum;
            sayi1 = Convert.ToInt32(str11);
            sayi2 = Convert.ToInt32(str12);
            sum = sayi1 + sayi2;
            Console.WriteLine(sum);

            // Parse
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "12";
            string metin2 = "10.25";
            int sayi11;
            double double1;

            sayi11 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine(sayi11 + ", " + double1);
        }
    }
}
