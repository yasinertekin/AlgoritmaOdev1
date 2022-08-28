using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				ArrayList TamBolunenler = new ArrayList();
				Console.Write("Lütfen Birinci Sayıyı Giriniz:");
				int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
                int m = Convert.ToInt32(Console.ReadLine());
				

				if (n < 0 && m < 0)
				{
					Console.WriteLine("Lütfen Pozitif Bir Değer Giriniz");
				}

				Console.WriteLine("Lütfen" + " " + n + " " + "tane sayı giriniz");
				for (int i = 0; i < n; i++)
				{
					int NSayilar = Convert.ToInt32(Console.ReadLine());

					if (NSayilar % m == 0)
					{
						TamBolunenler.Add(NSayilar);
					}

				}

                Console.WriteLine("Tam Bölünen Sayılar ");

                foreach (var item in TamBolunenler)
                {
                    Console.WriteLine(item);
                }
            }
			catch (Exception)
			{

				Console.WriteLine("Lütfen Numeric Bir Değer Giriniz ");
			}
        }
    }
}