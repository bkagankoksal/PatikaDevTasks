using System;

namespace csharptask2patika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            y += 2;
            y /= 1;
            x *= 2;

            //Mantıksal Operatörler ||, &&, !
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }
            //İlişkisel Operatörler <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            sonuc = a > b;
            sonuc = a >= b;
            sonuc = a <= b;
            sonuc = a == b;
            sonuc = a != b;

            //Aritmetik Operatörler /, *, +, -
            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1 / sayi2;
            int sonuc2 = sayi1 * sayi2;
            int sonuc3 = sayi1 + sayi2;
            int sonuc4 = sayi1++;

            // % mod
            int sonuc5 = 20 % 3;
        }
    }
}
