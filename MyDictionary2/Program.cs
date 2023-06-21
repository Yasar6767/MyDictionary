using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenciler = new Dictionary<int, string>();
            Ogrenciler.Add(1, "Yaşar");
            Ogrenciler.Add(2, "Elif");
            Ogrenciler.Add(3, "Azra");
            Ogrenciler.Add(4, "Selim");

            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }

            var ogrenciSayisi = Ogrenciler.Count();
            Console.WriteLine("Kaç öğrenci var?");
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine();

            Ogrenciler.Remove(1);

            foreach (var ogrenci in Ogrenciler)
            {
                
                Console.WriteLine(ogrenci);
            }


        }
    }
}
