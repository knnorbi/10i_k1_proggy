using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20210113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = new string[2];
            for (int i = 0; i < sorok.Length; i++)
            {
                sorok[i] = Console.ReadLine();
            }

            StreamWriter sw = new StreamWriter(@"c:\Users\Norbi\source\repos\10i_k1_proggy\20210113\bin\Debug\5soros.txt");
            for (int i = 0; i < sorok.Length; i++)
            {
                sw.WriteLine(sorok[i]);
            }
            sw.Close();

            Console.WriteLine("Kiirtam a filet!");
            Console.WriteLine("Most beolvasom!");

            StreamReader sr = new StreamReader("5soros.txt");
            string sor;
            while ((sor = sr.ReadLine()) != null)
            {
                Console.WriteLine(sor);
            }
            sr.Close();

            Console.WriteLine("Most beolvasom maskent!");
            StreamReader sr2 = new StreamReader("5soros.txt");
            bool vegeAFilenak = false;
            while (!vegeAFilenak)
            {
                string sor2 = sr2.ReadLine();
                if (sor2 == null)
                {
                    vegeAFilenak = true;
                }
                else
                {
                    Console.WriteLine(sor2);
                }
            }
            sr2.Close();


            Console.ReadLine();
        }
    }
}
