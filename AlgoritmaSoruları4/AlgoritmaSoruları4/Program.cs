using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<string> metin = new List<string>();

            Console.Write("Lütfen Bir Cümle Giriniz: ");

            string cümle = Console.ReadLine();

            metin.Add(cümle);

            string[] kelimeler = cümle.Split(' ');

        

            Console.WriteLine("Kelime Sayısı: " + kelimeler.Length);

            
            string new_cümle = cümle.Replace(" ", "");
            Console.WriteLine("Harf Sayısı: " + new_cümle.Length);



           

            

            


        }
    }
}