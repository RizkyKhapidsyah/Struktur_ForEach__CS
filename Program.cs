using System;

namespace Struktur_ForEach__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] Stringarray = { "Satu", "Dua", "Tiga" };

            foreach (String element in Stringarray)
            {
                Console.WriteLine(element + " ");
            }

            Console.Read();
        }
    }
}
