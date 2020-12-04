using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201204
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] t = new int[r.Next(20, 51)];

            Console.WriteLine("Irj be egy szamot!");
            int szam = int.Parse(Console.ReadLine());

            for (int i = 0; i < t.Length; i++)
            {
                if(r.Next(2) == 0)
                {
                    t[i] = szam;
                }
                else
                {
                    t[i] = 42;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(i + "->" + t[i]);
            }

            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                osszeg += t[i];
            }
            Console.WriteLine(osszeg);

            int darab = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == szam)
                {
                    darab++;
                }
            }
            Console.WriteLine(darab);

            Console.ReadKey();
        }
    }
}
