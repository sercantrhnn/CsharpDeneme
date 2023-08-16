using System;
using System.Collections;

namespace Koleksiyonlar_Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayiListesi = new ArrayList();
            ArrayList asalList = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz: ",i);
                sayiListesi.Add(Console.ReadLine());
            }

            foreach (var item in sayiListesi)
            {
                if (Convert.ToInt32(item) ==2 || Convert.ToInt32(item) % 2 !=0)
                {
                    asalList.Add(item);
                }
                else
                {
                    asalDegil.Add(item);
                }
            }

           asalList.Sort();
           asalList.Reverse();
           asalDegil.Sort();
           asalDegil.Reverse();

           foreach (var item in asalList)
           {
            Console.WriteLine(item);
           }

           foreach (var item in asalDegil)
           {
            Console.WriteLine(item);
           }

        
           

            
        }
    }
}
