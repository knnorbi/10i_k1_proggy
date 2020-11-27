using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201127
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] b = new int[10];
            // b[0] = 42;

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = random.Next(1, 101);
            }

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            int darab = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] % 2 == 0)
                {
                    darab++;
                }
            }

            Console.WriteLine(darab + " darab paros szam van.");

            int osszeg = 0;
            for (int i = 0; i < b.Length; i++)
            {
                osszeg += b[i];
            }

            Console.WriteLine("A szamok osszege: " + osszeg);
        }
    }
}
