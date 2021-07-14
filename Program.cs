using System;

namespace FonksiyonHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Faktoriyeli Bulunacak Sayıyı Giriniz");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Girilen Sayının Faktoriyeli:" + fact);
            Console.ReadLine();
        }
    }
}
