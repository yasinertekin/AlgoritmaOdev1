using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Pozitif Bir sayı Giriniz: ");
            ArrayList ÇiftSayilar = new ArrayList();
            try
            {

                int n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Negatif Bir Sayı girdiniz lütfen pozitif bir sayi giriniz ");
                }


                Console.WriteLine("Lütfen" + " "+ n + " " + "tane değer giriniz");


                

                for (int i = 0; i < n; i++)
                {
                    int deger = Convert.ToInt32(Console.ReadLine());

                    if (deger % 2 == 0)
                    {
                        ÇiftSayilar.Add(deger);
                    }
                }

                Console.WriteLine("Girdiğiniz sayılardan Çift Olanlar");
                foreach (var item in ÇiftSayilar)
                {
                    Console.WriteLine(item);
                }



            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen Numeric Bir Değer Giriniz");
            }
            

        }
    }

    
}