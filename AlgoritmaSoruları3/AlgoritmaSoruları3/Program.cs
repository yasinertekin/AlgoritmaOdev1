using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

			ArrayList Kelimeler = new ArrayList();
			try
			{
				Console.Write("Lütfen Pozitif Bir Değer Giriniz: ");
				int n = Convert.ToInt32(Console.ReadLine());

				if (n < 0)
				{
					Console.WriteLine("Negatif Bir Değer Girdiniz");
				}


				for (int i = 0; i < n; i++)
				{
					string kelime = Console.ReadLine();
					Kelimeler.Add(kelime);
				}


				Kelimeler.Reverse();

				Console.WriteLine("*******Girdiğiniz Kelimelerin Tersten Yazılmış Hali*******");
				foreach (var item in Kelimeler)
				{
					Console.WriteLine(item);
				}


			}
			catch (Exception)
			{

				Console.WriteLine("Lütfen numeric bir değer giriniz");
			}
        }
    }
}