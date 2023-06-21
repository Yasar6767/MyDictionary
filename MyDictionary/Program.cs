using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary myDictionary = new MyDictionary();
        }
    }

    class MyDictionary
    {
        public MyDictionary()
        {
            Dictionary<int, string> Ogrenciler = new Dictionary<int, string>()
            {
                {1, "Yaşar"},
                {2, "Elif"},
                {3, "Azra"},
                {4, "Selim"}
            };

            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine("Key{0}, Value{1} "  + ogrenci.Key + " " + ogrenci.Value );
            }
        }

    }
}
