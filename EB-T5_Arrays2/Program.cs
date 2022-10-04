using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 20, 30, 10, 30, 40, 10, 50, 60, 75, 30, 65, 50, 70, 80, 10, 85 };

            int adet = 0;
            int sayi;
            Console.Write("Lütfen Bir Sayı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }
            }

            if (adet == 0)
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulunamadı...");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulundu");
                Console.WriteLine("Adet:" + adet);
            }
            Console.ReadLine();

        }
    }
}

