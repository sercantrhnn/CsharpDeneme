using System;

namespace Koleksiyonlar_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[7];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz.", i+1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            int[] sayilarKucuk = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sayilarKucuk[i] = sayilar[i];
            }

            int[] sayilarBuyuk = new int[3];
            Array.Reverse(sayilar);
            for (int i = 0; i < 3; i++)
            {
                sayilarBuyuk[i] = sayilar[i];
            }
            int toplamBuyuk = 0;
            foreach (var item in sayilarBuyuk)
            {
                toplamBuyuk += item;
            }
            Console.Write("Büyük sayıların ortalaması: ");
            Console.WriteLine(toplamBuyuk/sayilarBuyuk.Length);

            int toplamKucuk = 0;
            foreach (var item in sayilarKucuk)
            {
                toplamKucuk += item;
            }

            Console.Write("Küçük sayıların ortalaması: ");
            Console.WriteLine(toplamKucuk/sayilarKucuk.Length);
        }
    }
}
